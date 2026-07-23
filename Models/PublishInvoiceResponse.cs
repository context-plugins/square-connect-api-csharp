using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a <c>PublishInvoice</c> response.
/// </summary>
public record PublishInvoiceResponse
{
    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Stores information about an invoice. You use the Invoices API to create and manage
    /// invoices. For more information, see <see href="https://developer.squareup.com/docs/invoices-api/overview">Manage Invoices Using the Invoices API</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invoice")]
    public Invoice? Invoice { get; init; }
}
