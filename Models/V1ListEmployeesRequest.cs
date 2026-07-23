using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record V1ListEmployeesRequest
{
    /// <summary>
    /// A pagination cursor to retrieve the next set of results for your
    /// original query to the endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("batch_token")]
    public string? BatchToken { get; init; }

    /// <summary>
    /// If filtering results by their created_at field, the beginning of the requested reporting period, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_created_at")]
    public string? BeginCreatedAt { get; init; }

    /// <summary>
    /// If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_updated_at")]
    public string? BeginUpdatedAt { get; init; }

    /// <summary>
    /// If filtering results by their created_at field, the end of the requested reporting period, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_created_at")]
    public string? EndCreatedAt { get; init; }

    /// <summary>
    /// If filtering results by there updated_at field, the end of the requested reporting period, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_updated_at")]
    public string? EndUpdatedAt { get; init; }

    /// <summary>
    /// If provided, the endpoint returns only employee entities with the specified external_id.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; init; }

    /// <summary>
    /// The maximum integer number of employee entities to return in a single response. Default 100, maximum 200.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// The order in which employees are listed in the response, based on their created_at field.      Default value: ASC
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public string? Order { get; init; }

    /// <summary>
    /// If provided, the endpoint returns only employee entities with the specified status (ACTIVE or INACTIVE).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
