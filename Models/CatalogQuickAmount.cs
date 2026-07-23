using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a Quick Amount in the Catalog.
/// </summary>
public record CatalogQuickAmount
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Money Amount { get; init; }

    /// <summary>
    /// The order in which this Quick Amount should be displayed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public long? Ordinal { get; init; }

    /// <summary>
    /// Describes the ranking of the Quick Amount provided by machine learning model, in the range [0, 100].
    /// MANUAL type amount will always have score = 100.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("score")]
    public long? Score { get; init; }

    /// <summary>
    /// Represents the type of the Quick Amount.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
