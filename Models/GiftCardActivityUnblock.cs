using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Present only when <c>GiftCardActivityType</c> is UNBLOCK.
/// </summary>
public record GiftCardActivityUnblock
{
    [JsonPropertyName("reason")]
    public required object Reason { get; init; }
}
