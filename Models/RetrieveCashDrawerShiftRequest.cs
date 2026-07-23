using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RetrieveCashDrawerShiftRequest
{
    /// <summary>
    /// The ID of the location to retrieve cash drawer shifts from.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }
}
