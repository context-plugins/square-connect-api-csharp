using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SquareConnectApi.Core;
using SquareConnectApi.Core.ErrorResponse;
using SquareConnectApi.Core.Exceptions;
using SquareConnectApi.Core.Models;
using SquareConnectApi.Core.Request;
using SquareConnectApi.Core.Response;
using SquareConnectApi.Models;

namespace SquareConnectApi.Api;

public sealed class Catalog
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Catalog(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BatchDeleteCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchDeleteCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a set of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see>s based on the
    /// provided list of target IDs and returns a set of successfully deleted IDs in
    /// the response. Deletion is a cascading event such that all children of the
    /// targeted object are also deleted. For example, deleting a CatalogItem will
    /// also delete all of its <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see>
    /// children.
    /// <para>
    /// <c>BatchDeleteCatalogObjects</c> succeeds even if only a portion of the targeted
    /// IDs can be deleted. The response will only include IDs that were
    /// actually deleted.
    /// </para>
    /// </remarks>
    public Task<BatchDeleteCatalogObjectsResponse> BatchDeleteCatalogObjects(BatchDeleteCatalogObjectsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/batch-delete"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchDeleteCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// BatchRetrieveCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a set of objects based on the provided ID.
    /// Each <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see> returned in the set includes all of its
    /// child information including: all of its
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see> objects, references to
    /// its <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogModifierList">CatalogModifierList</see> objects, and the ids of
    /// any <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax">CatalogTax</see> objects that apply to it.
    /// </remarks>
    public Task<BatchRetrieveCatalogObjectsResponse> BatchRetrieveCatalogObjects(BatchRetrieveCatalogObjectsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/batch-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchRetrieveCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// BatchUpsertCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchUpsertCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates up to 10,000 target objects based on the provided
    /// list of objects. The target objects are grouped into batches and each batch is
    /// inserted/updated in an all-or-nothing manner. If an object within a batch is
    /// malformed in some way, or violates a database constraint, the entire batch
    /// containing that item will be disregarded. However, other batches in the same
    /// request may still succeed. Each batch may contain up to 1,000 objects, and
    /// batches will be processed in order as long as the total object count for the
    /// request (items, variations, modifier lists, discounts, and taxes) is no more
    /// than 10,000.
    /// </remarks>
    public Task<BatchUpsertCatalogObjectsResponse> BatchUpsertCatalogObjects(BatchUpsertCatalogObjectsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/batch-upsert"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchUpsertCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CatalogInfo
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CatalogInfoResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves information about the Square Catalog API, such as batch size
    /// limits that can be used by the <c>BatchUpsertCatalogObjects</c> endpoint.
    /// </remarks>
    public Task<CatalogInfoResponse> CatalogInfo(CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/info"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CatalogInfoResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteCatalogObject
    /// </summary>
    /// <param name="objectId">The ID of the catalog object to be deleted. When an object is deleted, other objects in the graph that depend on that object will be deleted as well (for example, deleting a catalog item will delete its catalog item variations).</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCatalogObjectResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a single <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> based on the
    /// provided ID and returns the set of successfully deleted IDs in the response.
    /// Deletion is a cascading event such that all children of the targeted object
    /// are also deleted. For example, deleting a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see>
    /// will also delete all of its
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see> children.
    /// </remarks>
    public Task<DeleteCatalogObjectResponse> DeleteCatalogObject(string objectId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/object/{object_id}"),
            [new TemplateParam("object_id", objectId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCatalogObjectResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListCatalog
    /// </summary>
    /// <param name="cursor">The pagination cursor returned in the previous response. Leave unset for an initial request. The page size is currently set to be 100. See <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see> for more information.</param>
    /// <param name="types">An optional case-insensitive, comma-separated list of object types to retrieve.  The valid values are defined in the <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/CatalogObjectType">CatalogObjectType</see> enum, including <c>ITEM</c>, <c>ITEM_VARIATION</c>, <c>CATEGORY</c>, <c>DISCOUNT</c>, <c>TAX</c>, <c>MODIFIER</c>, <c>MODIFIER_LIST</c>, or <c>IMAGE</c>.  If this is unspecified, the operation returns objects of all the types at the version of the Square API used to make the request.</param>
    /// <param name="catalogVersion">The specific version of the catalog objects to be included in the response.  This allows you to retrieve historical versions of objects. The specified version value is matched against the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s' <c>version</c> attribute.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCatalogResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s that includes
    /// all objects of a set of desired types (for example, all <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see>
    /// and <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax">CatalogTax</see> objects) in the catalog. The <c>types</c> parameter
    /// is specified as a comma-separated list of valid <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> types:
    /// <c>ITEM</c>, <c>ITEM_VARIATION</c>, <c>MODIFIER</c>, <c>MODIFIER_LIST</c>, <c>CATEGORY</c>, <c>DISCOUNT</c>, <c>TAX</c>, <c>IMAGE</c>.
    /// <para>
    /// __Important:__ ListCatalog does not return deleted catalog items. To retrieve
    /// deleted catalog items, use <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-objects">SearchCatalogObjects</see>
    /// and set the <c>include_deleted_objects</c> attribute value to <c>true</c>.
    /// </para>
    /// </remarks>
    public Task<ListCatalogResponse> ListCatalog(string? cursor,
        string? types,
        long? catalogVersion,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/list"),
            [],
            [new Param("cursor", cursor), new Param("types", types), new Param("catalog_version", catalogVersion)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCatalogResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveCatalogObject
    /// </summary>
    /// <param name="objectId">The object ID of any type of catalog objects to be retrieved.</param>
    /// <param name="includeRelatedObjects">If <c>true</c>, the response will include additional objects that are related to the requested object, as follows:  If the <c>object</c> field of the response contains a <c>CatalogItem</c>, its associated <c>CatalogCategory</c>, <c>CatalogTax</c>, <c>CatalogImage</c> and <c>CatalogModifierList</c> objects will be returned in the <c>related_objects</c> field of the response. If the <c>object</c> field of the response contains a <c>CatalogItemVariation</c>, its parent <c>CatalogItem</c> will be returned in the <c>related_objects</c> field of the response.  Default value: <c>false</c></param>
    /// <param name="catalogVersion">Requests objects as of a specific version of the catalog. This allows you to retrieve historical versions of objects. The value to retrieve a specific version of an object can be found in the version field of <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCatalogObjectResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see> as a
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> based on the provided ID. The returned
    /// object includes all of the relevant <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see>
    /// information including: <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see>
    /// children, references to its
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogModifierList">CatalogModifierList</see> objects, and the ids of
    /// any <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax">CatalogTax</see> objects that apply to it.
    /// </remarks>
    public Task<RetrieveCatalogObjectResponse> RetrieveCatalogObject(string objectId,
        bool? includeRelatedObjects,
        long? catalogVersion,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/object/{object_id}"),
            [new TemplateParam("object_id", objectId)],
            [new Param("include_related_objects", includeRelatedObjects), new Param("catalog_version", catalogVersion)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCatalogObjectResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchCatalogItems
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchCatalogItemsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for catalog items or item variations by matching supported search attribute values, including
    /// custom attribute values, against one or more of the specified query expressions.
    /// <para>
    /// This (<c>SearchCatalogItems</c>) endpoint differs from the <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-objects">SearchCatalogObjects</see>
    /// endpoint in the following aspects:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>SearchCatalogItems</c> can only search for items or item variations, whereas <c>SearchCatalogObjects</c> can search for any type of catalog objects.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> supports the custom attribute query filters to return items or item variations that contain custom attribute values, where <c>SearchCatalogObjects</c> does not.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> does not support the <c>include_deleted_objects</c> filter to search for deleted items or item variations, whereas <c>SearchCatalogObjects</c> does.</description></item>
    ///   <item><description>The both endpoints use different call conventions, including the query filter formats.</description></item>
    /// </list>
    /// </remarks>
    public Task<SearchCatalogItemsResponse> SearchCatalogItems(SearchCatalogItemsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/search-catalog-items"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchCatalogItemsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchCatalogObjects
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchCatalogObjectsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> of any type by matching supported search attribute values,
    /// excluding custom attribute values on items or item variations, against one or more of the specified query expressions.
    /// <para>
    /// This (<c>SearchCatalogObjects</c>) endpoint differs from the <see href="https://developer.squareup.com/reference/square_2021-08-18/catalog-api/search-catalog-items">SearchCatalogItems</see>
    /// endpoint in the following aspects:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>SearchCatalogItems</c> can only search for items or item variations, whereas <c>SearchCatalogObjects</c> can search for any type of catalog objects.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> supports the custom attribute query filters to return items or item variations that contain custom attribute values, where <c>SearchCatalogObjects</c> does not.</description></item>
    ///   <item><description><c>SearchCatalogItems</c> does not support the <c>include_deleted_objects</c> filter to search for deleted items or item variations, whereas <c>SearchCatalogObjects</c> does.</description></item>
    ///   <item><description>The both endpoints have different call conventions, including the query filter formats.</description></item>
    /// </list>
    /// </remarks>
    public Task<SearchCatalogObjectsResponse> SearchCatalogObjects(SearchCatalogObjectsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchCatalogObjectsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateItemModifierLists
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateItemModifierListsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogModifierList">CatalogModifierList</see> objects
    /// that apply to the targeted <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see> without having
    /// to perform an upsert on the entire item.
    /// </remarks>
    public Task<UpdateItemModifierListsResponse> UpdateItemModifierLists(UpdateItemModifierListsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/update-item-modifier-lists"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateItemModifierListsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateItemTaxes
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateItemTaxesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogTax">CatalogTax</see> objects that apply to the
    /// targeted <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItem">CatalogItem</see> without having to perform an
    /// upsert on the entire item.
    /// </remarks>
    public Task<UpdateItemTaxesResponse> UpdateItemTaxes(UpdateItemTaxesRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/update-item-taxes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateItemTaxesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpsertCatalogObject
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpsertCatalogObjectResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates or updates the target <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>.
    /// </remarks>
    public Task<UpsertCatalogObjectResponse> UpsertCatalogObject(UpsertCatalogObjectRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/catalog/object"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<UpsertCatalogObjectResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
