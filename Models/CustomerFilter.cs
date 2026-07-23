using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a set of <c>CustomerQuery</c> filters used to limit the set of
/// customers returned by the <see href="https://developer.squareup.com/reference/square_2021-08-18/customers-api/search-customers">SearchCustomers</see> endpoint.
/// </summary>
public record CustomerFilter
{
    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public TimeRange? CreatedAt { get; init; }

    /// <summary>
    /// The creation source filter.
    /// <para>
    /// If one or more creation sources are set, customer profiles are included in,
    /// or excluded from, the result if they match at least one of the filter criteria.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creation_source")]
    public CustomerCreationSourceFilter? CreationSource { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public CustomerTextFilter? EmailAddress { get; init; }

    /// <summary>
    /// A filter to select resources based on an exact field value. For any given
    /// value, the value can only be in one property. Depending on the field, either
    /// all properties can be set or only a subset will be available.
    /// <para>
    /// Refer to the documentation of the field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group_ids")]
    public FilterValue? GroupIds { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public CustomerTextFilter? PhoneNumber { get; init; }

    /// <summary>
    /// A filter to select customers based on exact or fuzzy matching of
    /// customer attributes against a specified query. Depending on the customer attributes,
    /// the filter can be case-sensitive. This filter can be exact or fuzzy, but it cannot be both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public CustomerTextFilter? ReferenceId { get; init; }

    /// <summary>
    /// Represents a generic time range. The start and end values are
    /// represented in RFC 3339 format. Time ranges are customized to be
    /// inclusive or exclusive based on the needs of a particular endpoint.
    /// Refer to the relevant endpoint-specific documentation to determine
    /// how time ranges are handled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public TimeRange? UpdatedAt { get; init; }
}
