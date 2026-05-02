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

        // Should have generated the sort implementation
        Assert.True(result.GeneratedTrees.Length >= 1, $"Expected at least 1 generated tree, got {result.GeneratedTrees.Length}");

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
    public void NoAttributes_GeneratesNoSource()
    {
        var source = @"
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var result = SourceGeneratorDriver.RunGenerator(compilation);

        // No attributes means no generated source
        Assert.Empty(result.GeneratedTrees);
    }

    [Theory]
    [InlineData(8, "int")]
    [InlineData(16, "int")]
    [InlineData(28, "int")]
    [InlineData(32, "int")]
    [InlineData(48, "int")]
    [InlineData(64, "int")]
    [InlineData(48, "uint")]
    [InlineData(64, "uint")]
    [InlineData(48, "float")]
    [InlineData(64, "float")]
    [InlineData(8, "byte")]
    [InlineData(16, "byte")]
    [InlineData(48, "byte")]
    [InlineData(64, "byte")]
    [InlineData(8, "ushort")]
    [InlineData(16, "ushort")]
    [InlineData(8, "short")]
    [InlineData(16, "short")]
    [InlineData(12, "ushort")]
    [InlineData(12, "short")]
    [InlineData(8, "double")]
    [InlineData(16, "double")]
    [InlineData(28, "double")]
    [InlineData(48, "double")]
    [InlineData(64, "double")]
    [InlineData(16, "long")]
    [InlineData(16, "nint")]
    [InlineData(16, "nuint")]
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
    [InlineData(48)]
    [InlineData(64)]
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

        // Verify dispatch includes AVX2 path
        Assert.Contains("Avx2.IsSupported", generatedSource);
        // Sizes ≤32 also have an AVX-512F primary path
        if (size <= 32)
            Assert.Contains("Avx512F.IsSupported", generatedSource);
    }

    [Theory]
    [InlineData(16, "byte")]
    [InlineData(28, "byte")]
    [InlineData(16, "sbyte")]
    [InlineData(8, "short")]
    [InlineData(16, "short")]
    [InlineData(28, "short")]
    [InlineData(8, "ushort")]
    [InlineData(8, "int")]
    [InlineData(16, "int")]
    [InlineData(28, "int")]
    [InlineData(32, "int")]
    [InlineData(8, "uint")]
    [InlineData(8, "float")]
    [InlineData(16, "float")]
    public void ArmSimdCode_Compiles(int size, string typeName)
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

        // Verify ARM SIMD code was generated
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains($"SortSimdArm{size}_{typeName}"));
        Assert.NotNull(generatedSource);
    }

    [Theory]
    [InlineData(16, "long")]
    [InlineData(16, "double")]
    public void ArmSimdCode_NotGenerated_For64BitTypes(int size, string typeName)
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

        // Verify no ARM SIMD code was generated for 64-bit types
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("SortSimdArm"));
        Assert.Null(generatedSource);
    }

    [Fact]
    public void ArrayOverload_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(4, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        // Should contain the array overload with null-checking
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort(int[] array)"));
        Assert.NotNull(generatedSource);
        Assert.Contains("ArgumentNullException.ThrowIfNull", generatedSource);
        Assert.Contains("Sort((System.Span<int>)array)", generatedSource);
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

    [Fact]
    public void Sort_String_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(8, typeof(string))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        // Verify string.CompareOrdinal is used instead of > operator
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort8"));
        Assert.NotNull(generatedSource);
        Assert.Contains("string.CompareOrdinal", generatedSource);
    }

    [Theory]
    [InlineData(8, "ushort")]
    [InlineData(16, "ushort")]
    [InlineData(12, "ushort")]
    [InlineData(8, "short")]
    [InlineData(16, "short")]
    [InlineData(12, "short")]
    public void SimdCode_16Bit_HasAvx2Fallback(int size, string typeName)
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

        // Verify both AVX-512 and AVX2 methods were generated
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains($"SortSimd{size}_{typeName}") && s.Contains($"SortSimdAvx2_{size}_{typeName}"));
        Assert.NotNull(generatedSource);

        // Verify dispatch cascades from AVX-512 BW to AVX2
        Assert.Contains("Avx512BW.IsSupported", generatedSource);
        Assert.Contains("Avx2.IsSupported", generatedSource);
    }

    [Fact]
    public void ComparerOverload_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(4, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        // Should contain the comparer span overload
        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("IComparer<int>"));
        Assert.NotNull(generatedSource);
        Assert.Contains("Sort(System.Span<int> span, System.Collections.Generic.IComparer<int>?", generatedSource);
        Assert.Contains("Sort(int[] array, System.Collections.Generic.IComparer<int>?", generatedSource);
        Assert.Contains("ApplyNetworkWithComparer", generatedSource);
        Assert.Contains("Network4", generatedSource);
    }

    [Fact]
    public void ComparerOverload_MultipleTypes_GeneratesCode()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(4, typeof(int))]
[SortingNetwork(4, typeof(double))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("IComparer<int>") && s.Contains("IComparer<double>"));
        Assert.NotNull(generatedSource);
    }

    [Fact]
    public void OnFallback_GeneratesCallInsteadOfThrow()
    {
        var source = @"
using SortingNetworks;
using System;

[SortingNetwork(4, typeof(int))]
public partial class MySorter
{
    static void OnFallback(Span<int> span)
    {
        span.Sort();
    }
}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("OnFallback(span)"));
        Assert.NotNull(generatedSource);

        // Extract the span Sort method block (before the array overload)
        var spanSortStart = generatedSource.IndexOf("public static void Sort(System.Span<int> span)");
        var arraySortStart = generatedSource.IndexOf("public static void Sort(int[] array)");
        Assert.True(spanSortStart >= 0 && arraySortStart > spanSortStart);
        var spanSortBlock = generatedSource.Substring(spanSortStart, arraySortStart - spanSortStart);

        Assert.Contains("OnFallback(span)", spanSortBlock);
        Assert.DoesNotContain("throw new System.ArgumentException", spanSortBlock);
    }

    [Fact]
    public void WithoutOnFallback_GeneratesThrow()
    {
        var source = @"
using SortingNetworks;

[SortingNetwork(4, typeof(int))]
public partial class MySorter { }
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort4"));
        Assert.NotNull(generatedSource);
        Assert.Contains("throw new System.ArgumentException", generatedSource);
        Assert.DoesNotContain("OnFallback", generatedSource);
    }

    [Fact]
    public void OnFallback_MultipleTypes_OnlyFallbackForDefinedType()
    {
        var source = @"
using SortingNetworks;
using System;

[SortingNetwork(4, typeof(int))]
[SortingNetwork(4, typeof(double))]
public partial class MySorter
{
    static void OnFallback(Span<int> span)
    {
        span.Sort();
    }
}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort4"));
        Assert.NotNull(generatedSource);

        // Extract span Sort blocks only (before their array overloads)
        var intSpanSortIndex = generatedSource.IndexOf("public static void Sort(System.Span<int> span)");
        var intArraySortIndex = generatedSource.IndexOf("public static void Sort(int[] array)");
        var doubleSpanSortIndex = generatedSource.IndexOf("public static void Sort(System.Span<double> span)");
        var doubleArraySortIndex = generatedSource.IndexOf("public static void Sort(double[] array)");
        Assert.True(intSpanSortIndex >= 0, "Expected int span Sort method");
        Assert.True(doubleSpanSortIndex >= 0, "Expected double span Sort method");

        var intSpanSortBlock = generatedSource.Substring(intSpanSortIndex, intArraySortIndex - intSpanSortIndex);
        var doubleSpanSortBlock = generatedSource.Substring(doubleSpanSortIndex, doubleArraySortIndex - doubleSpanSortIndex);

        Assert.Contains("OnFallback(span)", intSpanSortBlock);
        Assert.DoesNotContain("throw new System.ArgumentException", intSpanSortBlock);

        Assert.Contains("throw new System.ArgumentException", doubleSpanSortBlock);
        Assert.DoesNotContain("OnFallback", doubleSpanSortBlock);
    }

    [Fact]
    public void OnFallback_WithComparer_GeneratesComparerCall()
    {
        var source = @"
using SortingNetworks;
using System;
using System.Collections.Generic;

[SortingNetwork(4, typeof(int))]
public partial class MySorter
{
    static void OnFallback(Span<int> span)
    {
        span.Sort();
    }
    static void OnFallback(Span<int> span, IComparer<int> comparer)
    {
        int[] temp = span.ToArray();
        Array.Sort(temp, comparer);
        temp.CopyTo(span);
    }
}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort4"));
        Assert.NotNull(generatedSource);

        // Span overload should call OnFallback(span)
        Assert.Contains("OnFallback(span)", generatedSource);
        // Comparer overload should call OnFallback(span, comparer)
        Assert.Contains("OnFallback(span, comparer)", generatedSource);
        // No throws since both overloads have fallbacks
        Assert.DoesNotContain("throw new System.ArgumentException", generatedSource);
    }

    [Fact]
    public void OnFallback_SpanOnly_ComparerStillThrows()
    {
        var source = @"
using SortingNetworks;
using System;

[SortingNetwork(4, typeof(int))]
public partial class MySorter
{
    static void OnFallback(Span<int> span)
    {
        span.Sort();
    }
}
";
        var compilation = SourceGeneratorDriver.CreateCompilation(source);
        var (result, updatedCompilation) = SourceGeneratorDriver.RunGeneratorWithCompilation(compilation);

        var errors = result.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error).ToArray();
        Assert.Empty(errors);

        var compilationErrors = SourceGeneratorDriver.GetErrors(updatedCompilation);
        Assert.Empty(compilationErrors);

        var generatedSource = result.GeneratedTrees
            .Select(t => t.GetText().ToString())
            .FirstOrDefault(s => s.Contains("Sort4"));
        Assert.NotNull(generatedSource);

        // Span Sort calls OnFallback
        Assert.Contains("OnFallback(span)", generatedSource);
        // Comparer Sort still throws (no 2-param OnFallback defined)
        Assert.Contains("throw new System.ArgumentException", generatedSource);
        Assert.DoesNotContain("OnFallback(span, comparer)", generatedSource);
    }
}
