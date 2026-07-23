using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a <c>CreateInvoice</c> request.
/// </summary>
public record CreateInvoiceRequest
{
    /// <summary>
    /// A unique string that identifies the <c>CreateInvoice</c> request. If you do not
    /// provide <c>idempotency_key</c> (or provide an empty string as the value), the endpoint
    /// treats each request as independent.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(128)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// Stores information about an invoice. You use the Invoices API to create and manage
    /// invoices. For more information, see <see href="https://developer.squareup.com/docs/invoices-api/overview">Manage Invoices Using the Invoices API</see>.
    /// </summary>
    [JsonPropertyName("invoice")]
    public required Invoice Invoice { get; init; }
}
