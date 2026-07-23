using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The information needed to define a custom unit, provided by the seller.
/// </summary>
public record MeasurementUnitCustom
{
    /// <summary>
    /// The abbreviation of the custom unit, such as "bsh" (bushel). This appears
    /// in the cart for the Point of Sale app, and in reports.
    /// </summary>
    [JsonPropertyName("abbreviation")]
    public required string Abbreviation { get; init; }

    /// <summary>
    /// The name of the custom unit, for example "bushel".
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}
