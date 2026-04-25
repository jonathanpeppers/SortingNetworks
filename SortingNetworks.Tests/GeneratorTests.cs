using System.Linq;
using Microsoft.CodeAnalysis;

namespace SortingNetworks.Tests;

public class GeneratorTests
{
    [Fact]
    public void Sort4_Int_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(4, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        // Should have generated the attribute + the sort implementation
        Assert.True(result.GeneratedTrees.Length >= 2, $"Expected at least 2 generated trees, got {result.GeneratedTrees.Length}");

        // No generator diagnostics (errors)
        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        // Generated code should compile without errors
        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);
    }

    [Fact]
    public void Sort8_Byte_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(8, typeof(byte))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);
    }

    [Fact]
    public void Sort16_Double_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(16, typeof(double))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);
    }

    [Fact]
    public void Sort28_Int_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(28, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);
    }

    [Theory]
    [InlineData(32)]
    [InlineData(48)]
    [InlineData(64)]
    public void LargeSizes_UseBatcher_GeneratesCode(int size)
    {
        var source = $@"
using SortingNetworks;

[SortingNetwork({size}, typeof(int))]
public partial class MySorter {{ }}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);
    }

    [Fact]
    public void MultipleAttributes_GeneratesMultipleMethods()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(4, typeof(int))]
[SortingNetwork(8, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        // Both Sort4 and Sort8 should appear in generated code
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort4") && s.Contains("Sort8"));
        Assert.NotNull(generatedSource);
    }

    [Fact]
    public void InvalidSize_TooSmall_ReportsDiagnostic()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(1, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var result = SourceGeneratorDriver.RunGenerator(compilation);

        var errors = result.Diagnostics.Where(d => d.Id == "SN0001").ToArray();
        Assert.Single(errors);
    }

    [Fact]
    public void InvalidSize_TooLarge_ReportsDiagnostic()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(65, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var result = SourceGeneratorDriver.RunGenerator(compilation);

        var errors = result.Diagnostics.Where(d => d.Id == "SN0001").ToArray();
        Assert.Single(errors);
    }

    [Fact]
    public void WithNamespace_GeneratesCorrectly()
    {
        var source = @"
using SortingNetworks;

namespace MyApp.Sorting
{
    [SortingNetwork(4, typeof(int))]
    public partial class MySorter { }
}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        // Should contain the namespace
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("namespace MyApp.Sorting"));
        Assert.NotNull(generatedSource);
    }

    [Fact]
    public void NoAttributes_GeneratesOnlyAttributeSource()
    {
        var source = @"
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var result = SourceGeneratorDriver.RunGenerator(compilation);

        // Should generate only the attribute definition, not a sort implementation
        Assert.Single(result.GeneratedTrees);
        var text = result.GeneratedTrees[0].GetText().ToString();
        Assert.Contains("SortingNetworkAttribute", text);
    }

    [Theory]
    [InlineData(8, "int")]
    [InlineData(16, "int")]
    [InlineData(28, "int")]
    [InlineData(32, "int")]
    [InlineData(8, "byte")]
    [InlineData(16, "byte")]
    [InlineData(8, "double")]
    [InlineData(16, "double")]
    [InlineData(28, "double")]
    public void SimdCode_Compiles(int size, string typeName)
    {
        var source = $@"
using SortingNetworks;

[SortingNetwork({size}, typeof({typeName}))]
public partial class MySorter {{ }}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        // Verify SIMD code was generated (except for small sizes that skip SIMD)
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("SortSimd") || s.Contains("SortScalar"));
        Assert.NotNull(generatedSource);
    }

    [Theory]
    [InlineData(8)]
    [InlineData(16)]
    [InlineData(28)]
    public void Sort_Double_GeneratesAvx2Fallback(int size)
    {
        var source = $@"
using SortingNetworks;

[SortingNetwork({size}, typeof(double))]
public partial class MySorter {{ }}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        // Verify AVX2 fallback method was generated
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains($"SortSimdAvx2_{size}_double"));
        Assert.NotNull(generatedSource);

        // Verify dispatch includes both AVX-512 and AVX2 paths
        Assert.Contains("Avx512F.IsSupported", generatedSource);
        Assert.Contains("Avx2.IsSupported", generatedSource);
    }

    [Fact]
    public void DumpGeneratedCode_Sort16Int()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(16, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, _) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort16"));
        Assert.NotNull(generatedSource);

        // Output the generated code for manual inspection
        System.IO.File.WriteAllText(
            System.IO.Path.Combine(System.IO.Path.GetTempPath(), "sort16_int_generated.cs"),
            generatedSource);
    }
}
