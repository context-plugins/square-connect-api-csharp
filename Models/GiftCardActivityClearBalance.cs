using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a gift card activity of the CLEAR_BALANCE type.
/// </summary>
public record GiftCardActivityClearBalance
{
    [JsonPropertyName("reason")]
    public required object Reason { get; init; }
}
