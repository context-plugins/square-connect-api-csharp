using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a <c>PublishInvoice</c> request.
/// </summary>
public record PublishInvoiceRequest
{
    /// <summary>
    /// A unique string that identifies the <c>PublishInvoice</c> request. If you do not
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
    /// The version of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see> to publish.
    /// This must match the current version of the invoice; otherwise, the request is rejected.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }
}
