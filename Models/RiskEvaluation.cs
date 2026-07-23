using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents fraud risk information for the associated payment.
/// <para>
/// When you take a payment through Square's Payments API (using the <c>CreatePayment</c>
/// endpoint), Square evaluates it and assigns a risk level to the payment. Sellers
/// can use this information to determine the course of action (for example,
/// provide the goods/services or refund the payment).
/// </para>
/// </summary>
public record RiskEvaluation
{
    /// <summary>
    /// The timestamp when payment risk was evaluated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The risk level associated with the payment
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_level")]
    public string? RiskLevel { get; init; }
}
