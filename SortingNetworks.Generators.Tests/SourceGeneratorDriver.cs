using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace SortingNetworks.Generators.Tests;

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

        string dotNetAssemblyPath = System.IO.Path.GetDirectoryName(typeof(object).Assembly.Location)!;

        var references = new[]
        {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            MetadataReference.CreateFromFile(System.IO.Path.Combine(dotNetAssemblyPath, "System.Runtime.dll")),
            MetadataReference.CreateFromFile(System.IO.Path.Combine(dotNetAssemblyPath, "System.Private.CoreLib.dll")),
            MetadataReference.CreateFromFile(typeof(System.Runtime.CompilerServices.Unsafe).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(System.Runtime.InteropServices.MemoryMarshal).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(System.Span<>).Assembly.Location),
        };

        return CSharpCompilation.Create(
            assemblyName,
            new[] { syntaxTree },
            references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                .WithNullableContextOptions(NullableContextOptions.Enable));
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
    /// Gets all compilation errors from a compilation (severity = Error).
    /// </summary>
    public static ImmutableArray<Diagnostic> GetErrors(Compilation compilation)
    {
        return compilation.GetDiagnostics()
            .Where(d => d.Severity == DiagnosticSeverity.Error)
            .ToImmutableArray();
    }
}
