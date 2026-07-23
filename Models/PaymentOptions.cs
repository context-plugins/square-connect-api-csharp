using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record PaymentOptions
{
    /// <summary>
    /// Indicates whether the <c>Payment</c> objects created from this <c>TerminalCheckout</c> are automatically
    /// <c>COMPLETED</c> or left in an <c>APPROVED</c> state for later modification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autocomplete")]
    public bool? Autocomplete { get; init; }
}
