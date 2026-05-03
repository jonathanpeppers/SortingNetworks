using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

using SortingNetworks;
using SortingNetworks.Generators;

namespace SortingNetworks.Tests;

/// <summary>
/// Test helper for running source generators in-memory.
/// Follows the pattern from dotnet/maui's BindingSourceGen.UnitTests.
/// </summary>
public static class SourceGeneratorDriver
{
    /// <summary>
    /// Creates an in-memory compilation from a C# source string.
    /// </summary>
    public static CSharpCompilation CreateCompilation(string source, string assemblyName = "TestAssembly")
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(source);

        // Use ref assemblies from the SDK - these have the complete public API surface
        // The runtime assemblies may have forwarded types that don't resolve correctly
        var refAssemblyDir = FindRefAssemblyDirectory();

        var references = System.IO.Directory.GetFiles(refAssemblyDir, "*.dll")
            .Select(f =>
            {
                try { return (MetadataReference)MetadataReference.CreateFromFile(f); }
                catch { return null; }
            })
            .Where(r => r != null)
            .ToList()!;

        // Add reference to SortingNetworks assembly for the SortingNetworkAttribute type
        references.Add(MetadataReference.CreateFromFile(typeof(SortingNetworkAttribute).Assembly.Location));

        return CSharpCompilation.Create(
            assemblyName,
            new[] { syntaxTree },
            references!,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                .WithNullableContextOptions(NullableContextOptions.Enable)
                .WithAllowUnsafe(true));
    }

    private static string FindRefAssemblyDirectory()
    {
        // The runtime directory from .NET runtime should be something like:
        // C:\Program Files\dotnet\shared\Microsoft.NETCore.App\10.0.5\
        // We need: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\10.0.5\ref\net10.0\
        string runtimeDir = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()
            .TrimEnd(System.IO.Path.DirectorySeparatorChar);

        // Navigate up from shared/Microsoft.NETCore.App/10.0.x to the dotnet root
        string? dotnetRoot = System.IO.Path.GetDirectoryName(
            System.IO.Path.GetDirectoryName(
                System.IO.Path.GetDirectoryName(runtimeDir)));

        if (dotnetRoot != null)
        {
            string packsDir = System.IO.Path.Combine(dotnetRoot, "packs", "Microsoft.NETCore.App.Ref");
            if (System.IO.Directory.Exists(packsDir))
            {
                var versions = System.IO.Directory.GetDirectories(packsDir)
                    .OrderByDescending(d => d)
                    .ToArray();

                foreach (var versionDir in versions)
                {
                    string refParent = System.IO.Path.Combine(versionDir, "ref");
                    if (System.IO.Directory.Exists(refParent))
                    {
                        var refDirs = System.IO.Directory.GetDirectories(refParent)
                            .OrderByDescending(d => d)
                            .ToArray();
                        if (refDirs.Length > 0)
                            return refDirs[0];
                    }
                }
            }
        }

        // Fallback: use runtime directory (may produce warnings for native DLLs)
        return runtimeDir;
    }

    /// <summary>
    /// Runs the SortingNetworkGenerator on the given compilation.
    /// Returns the generator run result.
    /// </summary>
    public static GeneratorDriverRunResult RunGenerator(CSharpCompilation compilation)
    {
        var generator = new SortingNetworkGenerator();

        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: new[] { generator.AsSourceGenerator() },
            driverOptions: new GeneratorDriverOptions(
                disabledOutputs: IncrementalGeneratorOutputKind.None,
                trackIncrementalGeneratorSteps: true));

        driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out var updatedCompilation, out var diagnostics);

        return driver.GetRunResult();
    }

    /// <summary>
    /// Runs the generator and also returns the updated compilation for further analysis.
    /// </summary>
    public static (GeneratorDriverRunResult result, Compilation updatedCompilation) RunGeneratorWithCompilation(CSharpCompilation compilation)
    {
        var generator = new SortingNetworkGenerator();

        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: new[] { generator.AsSourceGenerator() },
            driverOptions: new GeneratorDriverOptions(
                disabledOutputs: IncrementalGeneratorOutputKind.None,
                trackIncrementalGeneratorSteps: true));

        driver = driver.RunGeneratorsAndUpdateCompilation(compilation, out var updatedCompilation, out _);

        return (driver.GetRunResult(), updatedCompilation);
    }

    /// <summary>
    /// Runs the generator twice: first on the initial compilation, then on a second compilation.
    /// Returns the run result from the second run so callers can inspect incremental step reasons.
    /// </summary>
    public static GeneratorDriverRunResult RunGeneratorTwice(CSharpCompilation first, CSharpCompilation second)
    {
        var generator = new SortingNetworkGenerator();

        GeneratorDriver driver = CSharpGeneratorDriver.Create(
            generators: new[] { generator.AsSourceGenerator() },
            driverOptions: new GeneratorDriverOptions(
                disabledOutputs: IncrementalGeneratorOutputKind.None,
                trackIncrementalGeneratorSteps: true));

        // First run — primes the cache
        driver = driver.RunGeneratorsAndUpdateCompilation(first, out _, out _);

        // Second run — should use cache if inputs are equal
        driver = driver.RunGeneratorsAndUpdateCompilation(second, out _, out _);

        return driver.GetRunResult();
    }

    /// <summary>
    /// Gets all compilation errors from a compilation (severity = Error).
    /// </summary>
    public static ImmutableArray<Diagnostic> GetErrors(Compilation compilation)
    {
        return compilation.GetDiagnostics()
            .Where(d => d.Severity == DiagnosticSeverity.Error)
            .ToImmutableArray();
    }
}
