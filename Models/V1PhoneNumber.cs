using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a phone number.
/// </summary>
public record V1PhoneNumber
{
    /// <summary>
    /// The phone number's international calling code. For US phone numbers, this value is +1.
    /// </summary>
    [JsonPropertyName("calling_code")]
    public required string CallingCode { get; init; }

    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; init; }
}
