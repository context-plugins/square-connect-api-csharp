using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A mapping between a temporary client-supplied ID and a permanent server-generated ID.
/// <para>
/// When calling <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/upsert-catalog-object">UpsertCatalogObject</see> or
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/batch-upsert-catalog-objects">BatchUpsertCatalogObjects</see> to
/// create a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> instance, you can supply
/// a temporary ID for the to-be-created object, especially when the object is to be referenced
/// elsewhere in the same request body. This temporary ID can be any string unique within
/// the call, but must be prefixed by "#".
/// </para>
/// <para>
/// After the request is submitted and the object created, a permanent server-generated ID is assigned
/// to the new object. The permanent ID is unique across the Square catalog.
/// </para>
/// </summary>
public record CatalogIdMapping
{
    /// <summary>
    /// The client-supplied temporary <c>#</c>-prefixed ID for a new <c>CatalogObject</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_object_id")]
    public string? ClientObjectId { get; init; }

    /// <summary>
    /// The permanent ID for the CatalogObject created by the server.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object_id")]
    public string? ObjectId { get; init; }
}
