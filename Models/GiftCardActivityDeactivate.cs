using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a gift card activity of the DEACTIVATE type.
/// </summary>
public record GiftCardActivityDeactivate
{
    [JsonPropertyName("reason")]
    public required object Reason { get; init; }
}
