using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1PaymentDiscount
/// </summary>
public record V1PaymentDiscount
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_money")]
    public V1Money? AppliedMoney { get; init; }

    /// <summary>
    /// The ID of the applied discount, if available. Discounts applied in older versions of Square Register might not have an ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_id")]
    public string? DiscountId { get; init; }

    /// <summary>
    /// The discount's name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
