using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record DisputeEvidenceCreatedWebhookObject
{
    /// <summary>
    /// Represents a dispute a cardholder initiated with their bank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public Dispute? Object { get; init; }
}
