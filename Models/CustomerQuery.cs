using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a query (including filtering criteria, sorting criteria, or both) used to search
/// for customer profiles.
/// </summary>
public record CustomerQuery
{
    /// <summary>
    /// Represents a set of <c>CustomerQuery</c> filters used to limit the set of
    /// customers returned by the <see href="https://developer.squareup.com/reference/square_2021-08-18/customers-api/search-customers">SearchCustomers</see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public CustomerFilter? Filter { get; init; }

    /// <summary>
    /// Specifies how searched customers profiles are sorted, including the sort key and sort order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public CustomerSort? Sort { get; init; }
}
