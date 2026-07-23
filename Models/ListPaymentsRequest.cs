using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a request to list payments using
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/list-payments">ListPayments</see>.
/// <para>
/// The maximum results per page is 100.
/// </para>
/// </summary>
public record ListPaymentsRequest
{
    /// <summary>
    /// The timestamp for the beginning of the reporting period, in RFC 3339 format.
    /// Inclusive. Default: The current time minus one year.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// The brand of the payment card (for example, VISA).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_brand")]
    public string? CardBrand { get; init; }

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
    /// The timestamp for the end of the reporting period, in RFC 3339 format.
    /// <para>
    /// Default: The current time.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// The last four digits of a payment card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_4")]
    public string? Last4 { get; init; }

    /// <summary>
    /// The maximum number of results to be returned in a single page.
    /// It is possible to receive fewer results than the specified limit on a given page.
    /// <para>
    /// The default value of 100 is also the maximum allowed value. If the provided value is
    /// greater than 100, it is ignored and the default value is used instead.
    /// </para>
    /// <para>
    /// Default: <c>100</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// Limit results to the location supplied. By default, results are returned
    /// for the default (main) location associated with the seller.
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
    /// The exact amount in the <c>total_money</c> for a payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    [Minimum(0)]
    public long? Total { get; init; }
}
