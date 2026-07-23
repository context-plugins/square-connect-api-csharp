using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Request object for the <see href="https://developer.squareup.com/reference/square_2021-08-18/locations-api/create-location">CreateLocation</see> endpoint.
/// </summary>
public record CreateLocationRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location")]
    public Location? Location { get; init; }
}
