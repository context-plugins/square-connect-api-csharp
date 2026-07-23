using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Returns a list of gift card activities. You can optionally specify a filter to retrieve a
/// subset of activites.
/// </summary>
public record ListGiftCardActivitiesRequest
{
    /// <summary>
    /// The timestamp for the beginning of the reporting period, in RFC 3339 format.
    /// Inclusive. Default: The current time minus one year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// If you do not provide the cursor, the call returns the first page of the results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The timestamp for the end of the reporting period, in RFC 3339 format.
    /// Inclusive. Default: The current time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// If you provide a gift card ID, the endpoint returns activities that belong
    /// to the specified gift card. Otherwise, the endpoint returns all gift card activities for
    /// the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_id")]
    [MaxLength(50)]
    public string? GiftCardId { get; init; }

    /// <summary>
    /// If you provide a limit value, the endpoint returns the specified number
    /// of results (or less) per page. A maximum value is 100. The default value is 50.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    [Minimum(1)]
    [Maximum(100)]
    public int? Limit { get; init; }

    /// <summary>
    /// If you provide a location ID, the endpoint returns gift card activities for that location.
    /// Otherwise, the endpoint returns gift card activities for all locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The order in which the endpoint returns the activities, based on <c>created_at</c>.
    /// - <c>ASC</c> - Oldest to newest.
    /// - <c>DESC</c> - Newest to oldest (default).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }

    /// <summary>
    /// If you provide a type, the endpoint returns gift card activities of this type.
    /// Otherwise, the endpoint returns all types of gift card activities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
