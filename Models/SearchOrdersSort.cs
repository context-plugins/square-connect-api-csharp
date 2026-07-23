using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Sorting criteria for a <c>SearchOrders</c> request. Results can only be sorted
/// by a timestamp field.
/// </summary>
public record SearchOrdersSort
{
    /// <summary>
    /// The field to sort by.
    /// <para>
    /// __Important:__ When using a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/SearchOrdersFilter">DateTimeFilter</see>,
    /// <c>sort_field</c> must match the timestamp field that the <c>DateTimeFilter</c> uses to
    /// filter. For example, if you set your <c>sort_field</c> to <c>CLOSED_AT</c> and you use a
    /// <c>DateTimeFilter</c>, your <c>DateTimeFilter</c> must filter for orders by their <c>CLOSED_AT</c> date.
    /// If this field does not match the timestamp field in <c>DateTimeFilter</c>,
    /// <c>SearchOrders</c> returns an error.
    /// </para>
    /// <para>
    /// Default: <c>CREATED_AT</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("sort_field")]
    public required string SortField { get; init; }

    /// <summary>
    /// The chronological order in which results are returned. Defaults to <c>DESC</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }
}
