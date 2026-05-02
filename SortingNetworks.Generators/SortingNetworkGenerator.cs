using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace SortingNetworks.Generators
{
    /// <summary>
    /// Roslyn incremental source generator that emits sorting network code
    /// for classes decorated with [SortingNetwork(size, typeof(T))].
    /// </summary>
    [Generator(LanguageNames.CSharp)]
    public class SortingNetworkGenerator : IIncrementalGenerator
    {
        private const int MinSize = 2;
        private const int MaxSize = 64;

        private static readonly HashSet<SpecialType> SupportedSpecialTypes = new HashSet<SpecialType>
        {
            SpecialType.System_Byte, SpecialType.System_SByte,
            SpecialType.System_Int16, SpecialType.System_UInt16,
            SpecialType.System_Int32, SpecialType.System_UInt32,
            SpecialType.System_Int64, SpecialType.System_UInt64,
            SpecialType.System_Char,
            SpecialType.System_Single, SpecialType.System_Double,
            SpecialType.System_IntPtr, SpecialType.System_UIntPtr
        };

        /// <summary>
        /// Maps a <see cref="SpecialType"/> to its C# keyword form so the
        /// generated code is always in-scope, operator-compatible, and stable
        /// regardless of target framework or <c>using</c> directives.
        /// </summary>
        private static string? GetKeywordName(SpecialType specialType) => specialType switch
        {
            SpecialType.System_Byte => "byte",
            SpecialType.System_SByte => "sbyte",
            SpecialType.System_Int16 => "short",
            SpecialType.System_UInt16 => "ushort",
            SpecialType.System_Int32 => "int",
            SpecialType.System_UInt32 => "uint",
            SpecialType.System_Int64 => "long",
            SpecialType.System_UInt64 => "ulong",
            SpecialType.System_Char => "char",
            SpecialType.System_Single => "float",
            SpecialType.System_Double => "double",
            SpecialType.System_IntPtr => "nint",
            SpecialType.System_UIntPtr => "nuint",
            _ => null,
        };

        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            // Register the attribute source so users don't need a separate package
            context.RegisterPostInitializationOutput(ctx =>
            {
                ctx.AddSource("SortingNetworkAttribute.g.cs", SourceText.From(AttributeSource, Encoding.UTF8));
            });

            // Find all class declarations with [SortingNetwork] attributes
            var classDeclarations = context.SyntaxProvider
                .ForAttributeWithMetadataName(
                    "SortingNetworks.SortingNetworkAttribute",
                    predicate: static (node, _) => node is ClassDeclarationSyntax,
                    transform: static (ctx, _) => GetGenerationInfo(ctx))
                .Where(static info => info != null)
                .Collect();

            context.RegisterSourceOutput(classDeclarations, static (spc, infos) => Execute(spc, infos!));
        }

        private static GenerationInfo? GetGenerationInfo(GeneratorAttributeSyntaxContext context)
        {
            var classSymbol = (INamedTypeSymbol)context.TargetSymbol;

            var attributes = new List<NetworkRequest>();
            foreach (var attr in context.Attributes)
            {
                if (attr.ConstructorArguments.Length < 2)
                    continue;

                var sizeArg = attr.ConstructorArguments[0];
                var typeArg = attr.ConstructorArguments[1];

                if (sizeArg.Value is int size && typeArg.Value is INamedTypeSymbol typeSymbol)
                {
                    var typeName = GetKeywordName(typeSymbol.SpecialType)
                        ?? typeSymbol.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat);
                    attributes.Add(new NetworkRequest(size, typeName, typeSymbol.SpecialType));
                }
            }

            if (attributes.Count == 0)
                return null;

            var namespaceName = classSymbol.ContainingNamespace.IsGlobalNamespace
                ? null
                : classSymbol.ContainingNamespace.ToDisplayString();

            return new GenerationInfo(
                classSymbol.Name,
                namespaceName,
                attributes.ToArray());
        }

        private static void Execute(SourceProductionContext context, ImmutableArray<GenerationInfo?> infos)
        {
            foreach (var info in infos)
            {
                if (info == null) continue;
                var source = GenerateSource(context, info);
                if (source != null)
                {
                    context.AddSource($"{info.ClassName}.g.cs", SourceText.From(source, Encoding.UTF8));
                }
            }
        }

        private static string? GenerateSource(SourceProductionContext context, GenerationInfo info)
        {
            var sb = new StringBuilder();
            sb.AppendLine("// <auto-generated />");
            sb.AppendLine("#nullable enable");
            sb.AppendLine();

            // Validate all requests and collect valid ones, grouped by type
            var validRequests = new List<NetworkRequest>();
            foreach (var request in info.Requests)
            {
                if (request.Size < MinSize || request.Size > MaxSize)
                {
                    context.ReportDiagnostic(Diagnostic.Create(
                        DiagnosticDescriptors.InvalidSize, Location.None, request.Size, MinSize, MaxSize));
                    continue;
                }

                if (!SupportedSpecialTypes.Contains(request.SpecialType))
                {
                    context.ReportDiagnostic(Diagnostic.Create(
                        DiagnosticDescriptors.UnsupportedType, Location.None, request.TypeName));
                    continue;
                }

                validRequests.Add(request);
            }

            if (validRequests.Count == 0)
                return null;

            // Check if any request will use SIMD
            bool needsSimdUsing = false;
            foreach (var request in validRequests)
            {
                if (SimdX86Emitter.CanEmit(request.SpecialType, request.Size) ||
                    SimdX86Emitter.CanEmitAvx2Fallback(request.SpecialType, request.Size) ||
                    SimdArmEmitter.CanEmit(request.SpecialType, request.Size))
                {
                    needsSimdUsing = true;
                    break;
                }
            }
            if (needsSimdUsing)
            {
                sb.AppendLine("using System.Runtime.Intrinsics;");
                sb.AppendLine();
            }

            if (info.Namespace != null)
            {
                sb.AppendLine($"namespace {info.Namespace}");
                sb.AppendLine("{");
            }

            sb.AppendLine($"    partial class {info.ClassName}");
            sb.AppendLine("    {");

            // Group requests by type to emit one public Sort(Span<T>) per type
            var byType = new Dictionary<string, List<NetworkRequest>>();
            foreach (var request in validRequests)
            {
                if (!byType.TryGetValue(request.TypeName, out var list))
                {
                    list = new List<NetworkRequest>();
                    byType[request.TypeName] = list;
                }
                list.Add(request);
            }

            // Pre-compute networks and SIMD info for each request
            var networksByRequest = new Dictionary<string, int[]>();
            var simdStepsByRequest = new Dictionary<string, List<List<(int A, int B)>>>();
            var avx2FallbackStepsByRequest = new Dictionary<string, List<List<(int A, int B)>>>();
            var simdArmStepsByRequest = new Dictionary<string, List<List<(int A, int B)>>>();
            foreach (var request in validRequests)
            {
                var key = $"{request.TypeName}_{request.Size}";
                var network = NetworkDatabase.GetNetwork(request.Size);
                if (network == null)
                {
                    network = BatcherNetworkBuilder.Generate(request.Size);
                }
                networksByRequest[key] = network;

                // Decompose the network into steps once, shared by all emitters
                bool canEmitSimd = SimdX86Emitter.CanEmit(request.SpecialType, request.Size);
                bool canEmitAvx2Fallback = SimdX86Emitter.CanEmitAvx2Fallback(request.SpecialType, request.Size);
                bool armCanEmit = SimdArmEmitter.CanEmit(request.SpecialType, request.Size);

                if (canEmitSimd || canEmitAvx2Fallback || armCanEmit)
                {
                    var decomposedSteps = SimdX86Emitter.DecomposeIntoSteps(network);
                    if (canEmitSimd)
                        simdStepsByRequest[key] = decomposedSteps;
                    if (canEmitAvx2Fallback)
                        avx2FallbackStepsByRequest[key] = decomposedSteps;
                    if (armCanEmit)
                        simdArmStepsByRequest[key] = decomposedSteps;
                }
            }

            // Emit one public Sort overload per type with flattened dispatch
            // Pattern matches the library: SIMD check → scalar fallback, all inline
            foreach (var kvp in byType)
            {
                var typeName = kvp.Key;
                var sizes = kvp.Value;
                sizes.Sort((a, b) => a.Size.CompareTo(b.Size));

                // Check which sizes have SIMD support
                var simdSizes = new List<NetworkRequest>();
                var avx2FallbackSizes = new List<NetworkRequest>();
                var simdArmSizes = new List<NetworkRequest>();
                foreach (var request in sizes)
                {
                    var key = $"{request.TypeName}_{request.Size}";
                    if (simdStepsByRequest.ContainsKey(key))
                        simdSizes.Add(request);
                    if (avx2FallbackStepsByRequest.ContainsKey(key))
                        avx2FallbackSizes.Add(request);
                    if (simdArmStepsByRequest.ContainsKey(key))
                        simdArmSizes.Add(request);
                }

                // Determine the SIMD guard condition strings
                string? simdGuard = null;
                if (simdSizes.Count > 0)
                {
                    simdGuard = SimdX86Emitter.GetGuardCondition(sizes[0].SpecialType);
                }
                string? simdArmGuard = null;
                if (simdArmSizes.Count > 0)
                {
                    simdArmGuard = SimdArmEmitter.GetGuardCondition(sizes[0].SpecialType);
                }

                sb.AppendLine($"        /// <summary>Sorts a span of {typeName} using an optimal sorting network based on span length.</summary>");
                sb.AppendLine($"        public static void Sort(System.Span<{typeName}> span)");
                sb.AppendLine("        {");
                sb.AppendLine("            int n = span.Length;");

                // Build the size check condition
                var sizeChecks = string.Join(" || ", sizes.Select(s => $"n == {s.Size}"));
                sb.AppendLine($"            if ({sizeChecks})");
                sb.AppendLine("            {");

                // SIMD dispatch block (if any sizes support SIMD)
                if (simdGuard != null && simdSizes.Count > 0)
                {
                    sb.AppendLine($"                if ({simdGuard})");
                    sb.AppendLine("                {");
                    if (simdSizes.Count == 1)
                    {
                        // Single SIMD size: guard by length check
                        sb.AppendLine($"                    if (n == {simdSizes[0].Size})");
                        sb.AppendLine("                    {");
                        sb.AppendLine($"                        SortSimd{simdSizes[0].Size}_{typeName}(span);");
                        sb.AppendLine("                        return;");
                        sb.AppendLine("                    }");
                    }
                    else
                    {
                        foreach (var request in simdSizes)
                        {
                            sb.AppendLine($"                    if (n == {request.Size}) {{ SortSimd{request.Size}_{typeName}(span); return; }}");
                        }
                    }
                    sb.AppendLine("                }");
                }

                // AVX2 fallback dispatch block (16-bit types and double)
                if (avx2FallbackSizes.Count > 0)
                {
                    string avx2Guard = SimdX86Emitter.GetAvx2FallbackGuardCondition();
                    // Use "else if" when there's a primary SIMD block above, plain "if" otherwise
                    string prefix = (simdGuard != null && simdSizes.Count > 0) ? "else if" : "if";
                    sb.AppendLine($"                {prefix} ({avx2Guard})");
                    sb.AppendLine("                {");
                    if (avx2FallbackSizes.Count == 1)
                    {
                        sb.AppendLine($"                    if (n == {avx2FallbackSizes[0].Size})");
                        sb.AppendLine("                    {");
                        sb.AppendLine($"                        SortSimdAvx2_{avx2FallbackSizes[0].Size}_{typeName}(span);");
                        sb.AppendLine("                        return;");
                        sb.AppendLine("                    }");
                    }
                    else
                    {
                        foreach (var request in avx2FallbackSizes)
                        {
                            sb.AppendLine($"                    if (n == {request.Size}) {{ SortSimdAvx2_{request.Size}_{typeName}(span); return; }}");
                        }
                    }
                    sb.AppendLine("                }");
                }

                // ARM SIMD dispatch block (if any sizes support ARM SIMD)
                if (simdArmGuard != null && simdArmSizes.Count > 0)
                {
                    sb.AppendLine($"                if ({simdArmGuard})");
                    sb.AppendLine("                {");
                    if (simdArmSizes.Count == 1)
                    {
                        sb.AppendLine($"                    if (n == {simdArmSizes[0].Size})");
                        sb.AppendLine("                    {");
                        sb.AppendLine($"                        SortSimdArm{simdArmSizes[0].Size}_{typeName}(span);");
                        sb.AppendLine("                        return;");
                        sb.AppendLine("                    }");
                    }
                    else
                    {
                        foreach (var request in simdArmSizes)
                        {
                            sb.AppendLine($"                    if (n == {request.Size}) {{ SortSimdArm{request.Size}_{typeName}(span); return; }}");
                        }
                    }
                    sb.AppendLine("                }");
                }

                // Scalar fallback: get ref and dispatch
                sb.AppendLine($"                ref {typeName} first = ref System.Runtime.InteropServices.MemoryMarshal.GetReference(span);");
                if (sizes.Count == 1)
                {
                    sb.AppendLine($"                Sort{sizes[0].Size}(ref first);");
                }
                else
                {
                    foreach (var request in sizes)
                    {
                        sb.AppendLine($"                if (n == {request.Size}) {{ Sort{request.Size}(ref first); return; }}");
                    }
                }
                sb.AppendLine("                return;");
                sb.AppendLine("            }");
                sb.AppendLine($"            throw new System.ArgumentException($\"No sorting network for length {{n}}. Supported lengths: {string.Join(", ", sizes.Select(s => s.Size.ToString()))}.\", nameof(span));");
                sb.AppendLine("        }");
                sb.AppendLine();

                // Emit matching array overload with null-checking
                sb.AppendLine($"        /// <summary>Sorts an array of {typeName} using an optimal sorting network based on array length.</summary>");
                sb.AppendLine($"        public static void Sort({typeName}[] array)");
                sb.AppendLine("        {");
                sb.AppendLine("            System.ArgumentNullException.ThrowIfNull(array);");
                sb.AppendLine($"            Sort((System.Span<{typeName}>)array);");
                sb.AppendLine("        }");
                sb.AppendLine();
            }

            // Emit private SIMD methods and scalar Sort{size} methods
            foreach (var request in validRequests)
            {
                var key = $"{request.TypeName}_{request.Size}";
                var network = networksByRequest[key];

                // Emit x86 SIMD method if applicable
                if (simdStepsByRequest.TryGetValue(key, out var simdSteps))
                {
                    var (simdMethod, _) = SimdX86Emitter.Emit(request.Size, request.TypeName, request.SpecialType, simdSteps);
                    if (!string.IsNullOrEmpty(simdMethod))
                    {
                        sb.AppendLine(simdMethod);
                        sb.AppendLine();
                    }
                }

                // Emit AVX2 fallback SIMD method if applicable (16-bit types and double)
                if (avx2FallbackStepsByRequest.TryGetValue(key, out var avx2Steps))
                {
                    var (avx2Method, _) = SimdX86Emitter.EmitAvx2Fallback(request.Size, request.TypeName, request.SpecialType, avx2Steps);
                    if (!string.IsNullOrEmpty(avx2Method))
                    {
                        sb.AppendLine(avx2Method);
                        sb.AppendLine();
                    }
                }

                // Emit ARM SIMD method if applicable
                if (simdArmStepsByRequest.TryGetValue(key, out var armSteps))
                {
                    var (armMethod, _) = SimdArmEmitter.Emit(request.Size, request.TypeName, request.SpecialType, armSteps);
                    if (!string.IsNullOrEmpty(armMethod))
                    {
                        sb.AppendLine(armMethod);
                        sb.AppendLine();
                    }
                }

                // Emit scalar method (takes ref T first, matches library pattern)
                sb.Append(ScalarEmitter.EmitSortMethod(request.Size, request.TypeName, network));
                sb.AppendLine();
            }

            sb.AppendLine("    }");

            if (info.Namespace != null)
            {
                sb.AppendLine("}");
            }

            return sb.ToString();
        }

        private const string AttributeSource = @"// <auto-generated />
#nullable enable

namespace SortingNetworks
{
    /// <summary>
    /// Marks a partial class for sorting network code generation.
    /// The source generator will emit a Sort method that uses an optimal
    /// sorting network for the specified size and type.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    internal sealed class SortingNetworkAttribute : System.Attribute
    {
        public int Size { get; }
        public System.Type ElementType { get; }

        public SortingNetworkAttribute(int size, System.Type elementType)
        {
            Size = size;
            ElementType = elementType;
        }
    }
}
";

        private sealed class GenerationInfo
        {
            public string ClassName { get; }
            public string? Namespace { get; }
            public NetworkRequest[] Requests { get; }

            public GenerationInfo(string className, string? ns, NetworkRequest[] requests)
            {
                ClassName = className;
                Namespace = ns;
                Requests = requests;
            }
        }

        private sealed class NetworkRequest
        {
            public int Size { get; }
            public string TypeName { get; }
            public SpecialType SpecialType { get; }

            public NetworkRequest(int size, string typeName, SpecialType specialType)
            {
                Size = size;
                TypeName = typeName;
                SpecialType = specialType;
            }
        }
    }
}
