using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RetrieveCatalogObjectRequest
{
    /// <summary>
    /// Requests objects as of a specific version of the catalog. This allows you to retrieve historical
    /// versions of objects. The value to retrieve a specific version of an object can be found
    /// in the version field of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// If <c>true</c>, the response will include additional objects that are related to the
    /// requested object, as follows:
    /// <para>
    /// If the <c>object</c> field of the response contains a <c>CatalogItem</c>, its associated
    /// <c>CatalogCategory</c>, <c>CatalogTax</c>, <c>CatalogImage</c> and <c>CatalogModifierList</c> objects will
    /// be returned in the <c>related_objects</c> field of the response. If the <c>object</c> field of
    /// the response contains a <c>CatalogItemVariation</c>, its parent <c>CatalogItem</c> will be returned
    /// in the <c>related_objects</c> field of the response.
    /// </para>
    /// <para>
    /// Default value: <c>false</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_related_objects")]
    public bool? IncludeRelatedObjects { get; init; }
}
