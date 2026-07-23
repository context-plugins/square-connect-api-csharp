using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record DisputeEvidenceCreatedWebhookData
{
    /// <summary>
    /// ID of the affected dispute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public DisputeEvidenceCreatedWebhookObject? Object { get; init; }

    /// <summary>
    /// Name of the affected dispute's type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
