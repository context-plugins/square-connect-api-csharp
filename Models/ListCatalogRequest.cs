using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record ListCatalogRequest
{
    /// <summary>
    /// The specific version of the catalog objects to be included in the response.
    /// This allows you to retrieve historical
    /// versions of objects. The specified version value is matched against
    /// the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s' <c>version</c> attribute.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// The pagination cursor returned in the previous response. Leave unset for an initial request.
    /// The page size is currently set to be 100.
    /// See <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see> for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// An optional case-insensitive, comma-separated list of object types to retrieve.
    /// <para>
    /// The valid values are defined in the <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/CatalogObjectType">CatalogObjectType</see> enum, including
    /// <c>ITEM</c>, <c>ITEM_VARIATION</c>, <c>CATEGORY</c>, <c>DISCOUNT</c>, <c>TAX</c>,
    /// <c>MODIFIER</c>, <c>MODIFIER_LIST</c>, or <c>IMAGE</c>.
    /// </para>
    /// <para>
    /// If this is unspecified, the operation returns objects of all the types at the version of the Square API used to make the request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("types")]
    public string? Types { get; init; }
}
