using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchRetrieveCatalogObjectsRequest
{
    /// <summary>
    /// The specific version of the catalog objects to be included in the response.
    /// This allows you to retrieve historical versions of objects. The specified version value is matched against
    /// the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s' <c>version</c> attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// If <c>true</c>, the response will include additional objects that are related to the
    /// requested objects, as follows:
    /// <para>
    /// If the <c>objects</c> field of the response contains a CatalogItem, its associated
    /// CatalogCategory objects, CatalogTax objects, CatalogImage objects and
    /// CatalogModifierLists will be returned in the <c>related_objects</c> field of the
    /// response. If the <c>objects</c> field of the response contains a CatalogItemVariation,
    /// its parent CatalogItem will be returned in the <c>related_objects</c> field of
    /// the response.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_related_objects")]
    public bool? IncludeRelatedObjects { get; init; }

    /// <summary>
    /// The IDs of the CatalogObjects to be retrieved.
    /// </summary>
    [JsonPropertyName("object_ids")]
    public required IReadOnlyList<string> ObjectIds { get; init; }
}
