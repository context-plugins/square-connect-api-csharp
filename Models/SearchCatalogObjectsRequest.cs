using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record SearchCatalogObjectsRequest
{
    /// <summary>
    /// Return objects modified after this <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">timestamp</see>, in RFC 3339
    /// format, e.g., <c>2016-09-04T23:59:33.123Z</c>. The timestamp is exclusive - objects with a
    /// timestamp equal to <c>begin_time</c> will not be included in the response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("begin_time")]
    public string? BeginTime { get; init; }

    /// <summary>
    /// The pagination cursor returned in the previous response. Leave unset for an initial request.
    /// See <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see> for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// If <c>true</c>, deleted objects will be included in the results. Deleted objects will have their
    /// <c>is_deleted</c> field set to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_deleted_objects")]
    public bool? IncludeDeletedObjects { get; init; }

    /// <summary>
    /// If <c>true</c>, the response will include additional objects that are related to the
    /// requested object, as follows:
    /// <para>
    /// If a CatalogItem is returned in the object field of the response,
    /// its associated CatalogCategory, CatalogTax objects,
    /// CatalogImage objects and CatalogModifierList objects
    /// will be included in the <c>related_objects</c> field of the response.
    /// </para>
    /// <para>
    /// If a CatalogItemVariation is returned in the object field of the
    /// response, its parent CatalogItem will be included in the <c>related_objects</c> field of
    /// the response.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_related_objects")]
    public bool? IncludeRelatedObjects { get; init; }

    /// <summary>
    /// A limit on the number of results to be returned in a single page. The limit is advisory -
    /// the implementation may return more or fewer results. If the supplied limit is negative, zero, or
    /// is higher than the maximum limit of 1,000, it will be ignored.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public int? Limit { get; init; }

    /// <summary>
    /// The desired set of object types to appear in the search results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_types")]
    public IReadOnlyList<string>? ObjectTypes { get; init; }

    /// <summary>
    /// A query composed of one or more different types of filters to narrow the scope of targeted objects when calling the <c>SearchCatalogObjects</c> endpoint.
    /// <para>
    /// Although a query can have multiple filters, only certain query types can be combined per call to <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-objects">SearchCatalogObjects</see>.
    /// Any combination of the following types may be used together:
    /// - <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogQueryExact">exact_query</see>
    /// - <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogQueryPrefix">prefix_query</see>
    /// - <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogQueryRange">range_query</see>
    /// - <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogQuerySortedAttribute">sorted_attribute_query</see>
    /// - <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogQueryText">text_query</see>
    /// All other query types cannot be combined with any others.
    /// </para>
    /// <para>
    /// When a query filter is based on an attribute, the attribute must be searchable.
    /// Searchable attributes are listed as follows, along their parent types that can be searched for with applicable query filters.
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Searchable attribute and objects queryable by searchable attributes **</description></item>
    ///   <item><description><c>name</c>:  <c>CatalogItem</c>, <c>CatalogItemVariation</c>, <c>CatalogCategory</c>, <c>CatalogTax</c>, <c>CatalogDiscount</c>, <c>CatalogModifier</c>, 'CatalogModifierList<c>, </c>CatalogItemOption<c>, </c>CatalogItemOptionValue`</description></item>
    ///   <item><description><c>description</c>: <c>CatalogItem</c>, <c>CatalogItemOptionValue</c></description></item>
    ///   <item><description><c>abbreviation</c>: <c>CatalogItem</c></description></item>
    ///   <item><description><c>upc</c>: <c>CatalogItemVariation</c></description></item>
    ///   <item><description><c>sku</c>: <c>CatalogItemVariation</c></description></item>
    ///   <item><description><c>caption</c>: <c>CatalogImage</c></description></item>
    ///   <item><description><c>display_name</c>: <c>CatalogItemOption</c></description></item>
    /// </list>
    /// <para>
    /// For example, to search for <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see> objects by searchable attributes, you can use
    /// the <c>"name"</c>, <c>"description"</c>, or <c>"abbreviation"</c> attribute in an applicable query filter.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("query")]
    public CatalogQuery? Query { get; init; }
}
