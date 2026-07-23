using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a <c>DeleteInvoice</c> request.
/// </summary>
public record DeleteInvoiceRequest
{
    /// <summary>
    /// The version of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see> to delete.
    /// If you do not know the version, you can call <see href="https://developer.squareup.com/reference/square_2021-08-18/invoices-api/get-invoice">GetInvoice</see> or
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/invoices-api/list-invoices">ListInvoices</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
