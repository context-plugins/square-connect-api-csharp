using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the parameters for a <c>DeprecatedCreateDisputeEvidenceFile</c> request.
/// </summary>
public record DeprecatedCreateDisputeEvidenceFileRequest
{
    /// <summary>
    /// The MIME type of the uploaded file.
    /// The type can be image/heic, image/heif, image/jpeg, application/pdf, image/png, or image/tiff.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content_type")]
    [StringLength(40, MinimumLength = 1)]
    public string? ContentType { get; init; }

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
