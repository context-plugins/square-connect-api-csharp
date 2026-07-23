using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record V1Money
{
    /// <summary>
    /// Amount in the lowest denominated value of this Currency. E.g. in USD
    /// these are cents, in JPY they are Yen (which do not have a 'cent' concept).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public int? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; init; }
}
