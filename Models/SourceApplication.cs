using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides information about the application used to generate a change.
/// </summary>
public record SourceApplication
{
    /// <summary>
    /// Read-only Square ID assigned to the application. Only used for
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/Product">Product</see> type <c>EXTERNAL_API</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("application_id")]
    public string? ApplicationId { get; init; }

    /// <summary>
    /// Read-only display name assigned to the application
    /// (e.g. <c>"Custom Application"</c>, <c>"Square POS 4.74 for Android"</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Read-only <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/Product">Product</see> type for the application.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product")]
    public string? Product { get; init; }
}
