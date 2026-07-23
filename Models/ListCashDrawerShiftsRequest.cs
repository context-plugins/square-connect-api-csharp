using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

public record ListCashDrawerShiftsRequest
{
    /// <summary>
    /// The inclusive start time of the query on opened_at, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// Opaque cursor for fetching the next page of results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The exclusive end date of the query on opened_at, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// Number of cash drawer shift events in a page of results (200 by
    /// default, 1000 max).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Maximum(1000)]
    public int? Limit { get; init; }

    /// <summary>
    /// The ID of the location to query for a list of cash drawer shifts.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// The order in which cash drawer shifts are listed in the response,
    /// based on their opened_at field. Default value: ASC
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }
}
