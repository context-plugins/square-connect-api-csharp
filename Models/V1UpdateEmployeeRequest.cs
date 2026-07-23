using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record V1UpdateEmployeeRequest
{
    /// <summary>
    /// Represents one of a business's employees.
    /// </summary>
    [JsonPropertyName("body")]
    public required V1Employee Body { get; init; }
}
