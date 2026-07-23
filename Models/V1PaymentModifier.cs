using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1PaymentModifier
/// </summary>
public record V1PaymentModifier
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_money")]
    public V1Money? AppliedMoney { get; init; }

    /// <summary>
    /// The ID of the applied modifier option, if available. Modifier options applied in older versions of Square Register might not have an ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modifier_option_id")]
    public string? ModifierOptionId { get; init; }

    /// <summary>
    /// The modifier option's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
