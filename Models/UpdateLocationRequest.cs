using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Request object for the <see href="https://developer.squareup.com/reference/square_2021-08-18/locations-api/update-location">UpdateLocation</see> endpoint.
/// </summary>
public record UpdateLocationRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public Location? Location { get; init; }
}
