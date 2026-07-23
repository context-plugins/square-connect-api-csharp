using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the parameters for a <c>CreateDisputeEvidenceText</c> request.
/// </summary>
public record CreateDisputeEvidenceTextRequest
{
    /// <summary>
    /// The evidence string.
    /// </summary>
    [JsonPropertyName("evidence_text")]
    [StringLength(500, MinimumLength = 1)]
    public required string EvidenceText { get; init; }

    /// <summary>
    /// The type of evidence you are uploading.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("evidence_type")]
    public string? EvidenceType { get; init; }

    /// <summary>
    /// The Unique ID. For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(45, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
