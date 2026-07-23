using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in the response body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/customer-groups-api/list-customer-groups">ListCustomerGroups</see> endpoint.
/// <para>
/// Either <c>errors</c> or <c>groups</c> is present in a given response (never both).
/// </para>
/// </summary>
public record ListCustomerGroupsResponse
{
    /// <summary>
    /// A pagination cursor to retrieve the next set of results for your
    /// original query to the endpoint. This value is present only if the request
    /// succeeded and additional results are available.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// A list of customer groups belonging to the current seller.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("groups")]
    public IReadOnlyList<CustomerGroup>? Groups { get; init; }
}
