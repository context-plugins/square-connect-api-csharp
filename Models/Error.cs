using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an error encountered during a request to the Connect API.
/// <para>
/// See <see href="https://developer.squareup.com/docs/build-basics/handling-errors">Handling errors</see> for more information.
/// </para>
/// </summary>
public record Error
{
    /// <summary>
    /// The high-level category for the error.
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; init; }

    /// <summary>
    /// The specific code of the error.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// A human-readable description of the error for debugging purposes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detail")]
    public string? Detail { get; init; }

    /// <summary>
    /// The name of the field provided in the original request (if any) that
    /// the error pertains to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field")]
    public string? Field { get; init; }
}
