using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a request to list refunds using
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/refunds-api/list-payment-refunds">ListPaymentRefunds</see>.
/// <para>
/// The maximum results per page is 100.
/// </para>
/// </summary>
public record ListPaymentRefundsRequest
{
    /// <summary>
    /// The timestamp for the beginning of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// Default: The current time minus one year.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this cursor to retrieve the next set of results for the original query.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// The timestamp for the end of the requested reporting period, in RFC 3339 format.
    /// <para>
    /// Default: The current time.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page.
    /// <para>
    /// It is possible to receive fewer results than the specified limit on a given page.
    /// </para>
    /// <para>
    /// If the supplied value is greater than 100, no more than 100 results are returned.
    /// </para>
    /// <para>
    /// Default: 100
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// Limit results to the location supplied. By default, results are returned
    /// for all locations associated with the seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// The order in which results are listed:
    /// - <c>ASC</c> - Oldest to newest.
    /// - <c>DESC</c> - Newest to oldest (default).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort_order")]
    public string? SortOrder { get; init; }

    /// <summary>
    /// If provided, only refunds with the given source type are returned.
    /// - <c>CARD</c> - List refunds only for payments where <c>CARD</c> was specified as the payment
    /// source.
    /// <para>
    /// Default: If omitted, refunds are returned regardless of the source type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_type")]
    public string? SourceType { get; init; }

    /// <summary>
    /// If provided, only refunds with the given status are returned.
    /// For a list of refund status values, see <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/PaymentRefund">PaymentRefund</see>.
    /// <para>
    /// Default: If omitted, refunds are returned regardless of their status.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
