using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates where to render a custom field on the Square-hosted invoice page and in emailed or PDF
/// copies of the invoice.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceCustomFieldPlacement>))]
public sealed record InvoiceCustomFieldPlacement : StringEnum<InvoiceCustomFieldPlacement>
{
    private InvoiceCustomFieldPlacement(string value) : base(value)
    {
    }

    /// <summary>
    /// Render the custom field above the invoice line items.
    /// </summary>
    public static readonly InvoiceCustomFieldPlacement AboveLineItems = new("ABOVE_LINE_ITEMS");

    /// <summary>
    /// Render the custom field below the invoice line items.
    /// </summary>
    public static readonly InvoiceCustomFieldPlacement BelowLineItems = new("BELOW_LINE_ITEMS");

    public static InvoiceCustomFieldPlacement FromValue(string value) => FromValueCore(value);
}
