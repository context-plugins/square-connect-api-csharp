using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a <c>CancelInvoice</c> request.
/// </summary>
public record CancelInvoiceRequest
{
    /// <summary>
    /// The version of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see> to cancel.
    /// If you do not know the version, you can call
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/invoices-api/get-invoice">GetInvoice</see> or <see href="https://developer.squareup.com/reference/square_2021-08-18/invoices-api/list-invoices">ListInvoices</see>.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }
}
