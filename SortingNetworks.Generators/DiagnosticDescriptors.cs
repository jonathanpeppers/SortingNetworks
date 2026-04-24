using Microsoft.CodeAnalysis;

namespace SortingNetworks.Generators
{
    internal static class DiagnosticDescriptors
    {
        public static readonly DiagnosticDescriptor InvalidSize = new(
            id: "SN0001",
            title: "Invalid sorting network size",
            messageFormat: "Sorting network size {0} is out of range. Must be between {1} and {2}.",
            category: "SortingNetworks",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor UnsupportedType = new(
            id: "SN0002",
            title: "Unsupported element type",
            messageFormat: "Type '{0}' is not supported for sorting networks. Use a primitive numeric type (byte, sbyte, short, ushort, int, uint, long, ulong, char, float, double, nint, nuint).",
            category: "SortingNetworks",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true);
    }
}
