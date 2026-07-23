using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a gift card activity of the BLOCK type.
/// </summary>
public record GiftCardActivityBlock
{
    [JsonPropertyName("reason")]
    public required object Reason { get; init; }
}
