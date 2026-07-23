using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Specific details for curbside pickup.
/// </summary>
public record OrderFulfillmentPickupDetailsCurbsidePickupDetails
{
    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>
    /// indicating when the buyer arrived and is waiting for pickup. The timestamp must be in RFC 3339 format
    /// (for example, "2016-09-04T23:59:33.123Z").
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_arrived_at")]
    public string? BuyerArrivedAt { get; init; }

    /// <summary>
    /// Specific details for curbside pickup, such as parking number and vehicle model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("curbside_details")]
    [MaxLength(250)]
    public string? CurbsideDetails { get; init; }
}
