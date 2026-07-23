using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The field to use for sorting.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceSortField>))]
public sealed record InvoiceSortField : StringEnum<InvoiceSortField>
{
    private InvoiceSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The field works as follows:
    /// <list type="bullet">
    ///   <item><description>If the invoice is a draft, it uses the invoice <c>created_at</c> date.</description></item>
    ///   <item><description>If the invoice is scheduled for publication, it uses the <c>scheduled_at</c> date.</description></item>
    ///   <item><description>If the invoice is published, it uses the invoice publication date.</description></item>
    /// </list>
    /// </summary>
    public static readonly InvoiceSortField InvoiceSortDate = new("INVOICE_SORT_DATE");

    public static InvoiceSortField FromValue(string value) => FromValueCore(value);
}
