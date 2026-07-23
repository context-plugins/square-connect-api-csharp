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

public sealed class Inventory
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Inventory(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// BatchChangeInventory
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchChangeInventoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Applies adjustments and counts to the provided item quantities.
    /// <para>
    /// On success: returns the current calculated counts for all objects
    /// referenced in the request.
    /// On failure: returns a list of related errors.
    /// </para>
    /// </remarks>
    public Task<BatchChangeInventoryResponse> BatchChangeInventory(BatchChangeInventoryRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/changes/batch-create"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchChangeInventoryResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// BatchRetrieveInventoryChanges
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryChangesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns historical physical counts and adjustments based on the
    /// provided filter criteria.
    /// <para>
    /// Results are paginated and sorted in ascending order according their
    /// <c>occurred_at</c> timestamp (oldest first).
    /// </para>
    /// <para>
    /// BatchRetrieveInventoryChanges is a catch-all query endpoint for queries
    /// that cannot be handled by other, simpler endpoints.
    /// </para>
    /// </remarks>
    public Task<BatchRetrieveInventoryChangesResponse> BatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/changes/batch-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchRetrieveInventoryChangesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// BatchRetrieveInventoryCounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryCountsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns current counts for the provided
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see>s at the requested
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see>s.
    /// <para>
    /// Results are paginated and sorted in descending order according to their
    /// <c>calculated_at</c> timestamp (newest first).
    /// </para>
    /// <para>
    /// When <c>updated_after</c> is specified, only counts that have changed since that
    /// time (based on the server timestamp for the most recent change) are
    /// returned. This allows clients to perform a "sync" operation, for example
    /// in response to receiving a Webhook notification.
    /// </para>
    /// </remarks>
    public Task<BatchRetrieveInventoryCountsResponse> BatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/counts/batch-retrieve"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchRetrieveInventoryCountsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeprecatedBatchChangeInventory
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchChangeInventoryResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-change-inventory">BatchChangeInventory</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<BatchChangeInventoryResponse> DeprecatedBatchChangeInventory(BatchChangeInventoryRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/batch-change"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchChangeInventoryResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeprecatedBatchRetrieveInventoryChanges
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryChangesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-changes">BatchRetrieveInventoryChanges</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<BatchRetrieveInventoryChangesResponse> DeprecatedBatchRetrieveInventoryChanges(BatchRetrieveInventoryChangesRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/batch-retrieve-changes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchRetrieveInventoryChangesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeprecatedBatchRetrieveInventoryCounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BatchRetrieveInventoryCountsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-counts">BatchRetrieveInventoryCounts</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<BatchRetrieveInventoryCountsResponse> DeprecatedBatchRetrieveInventoryCounts(BatchRetrieveInventoryCountsRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/batch-retrieve-counts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BatchRetrieveInventoryCountsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeprecatedRetrieveInventoryAdjustment
    /// </summary>
    /// <param name="adjustmentId">ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryAdjustment">InventoryAdjustment</see> to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryAdjustmentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/retrieve-inventory-adjustment">RetrieveInventoryAdjustment</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<RetrieveInventoryAdjustmentResponse> DeprecatedRetrieveInventoryAdjustment(string adjustmentId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/adjustment/{adjustment_id}"),
            [new TemplateParam("adjustment_id", adjustmentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryAdjustmentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeprecatedRetrieveInventoryPhysicalCount
    /// </summary>
    /// <param name="physicalCountId">ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount">InventoryPhysicalCount</see> to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryPhysicalCountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deprecated version of <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/retrieve-inventory-physical-count">RetrieveInventoryPhysicalCount</see> after the endpoint URL
    /// is updated to conform to the standard convention.
    /// </remarks>
    public Task<RetrieveInventoryPhysicalCountResponse> DeprecatedRetrieveInventoryPhysicalCount(string physicalCountId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/physical-count/{physical_count_id}"),
            [new TemplateParam("physical_count_id", physicalCountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryPhysicalCountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveInventoryAdjustment
    /// </summary>
    /// <param name="adjustmentId">ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryAdjustment">InventoryAdjustment</see> to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryAdjustmentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryAdjustment">InventoryAdjustment</see> object
    /// with the provided <c>adjustment_id</c>.
    /// </remarks>
    public Task<RetrieveInventoryAdjustmentResponse> RetrieveInventoryAdjustment(string adjustmentId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/adjustments/{adjustment_id}"),
            [new TemplateParam("adjustment_id", adjustmentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryAdjustmentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveInventoryChanges
    /// </summary>
    /// <param name="catalogObjectId">ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> to retrieve.</param>
    /// <param name="locationIds">The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see> IDs to look up as a comma-separated list. An empty list queries all locations.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryChangesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a set of physical counts and inventory adjustments for the
    /// provided <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> at the requested
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see>s.
    /// <para>
    /// You can achieve the same result by calling <see href="https://developer.squareup.com/reference/square_2021-08-18/inventory-api/batch-retrieve-inventory-changes">BatchRetrieveInventoryChanges</see>
    /// and having the <c>catalog_object_ids</c> list contain a single element of the <c>CatalogObject</c> ID.
    /// </para>
    /// <para>
    /// Results are paginated and sorted in descending order according to their
    /// <c>occurred_at</c> timestamp (newest first).
    /// </para>
    /// <para>
    /// There are no limits on how far back the caller can page. This endpoint can be
    /// used to display recent changes for a specific item. For more
    /// sophisticated queries, use a batch endpoint.
    /// </para>
    /// </remarks>
    public Task<RetrieveInventoryChangesResponse> RetrieveInventoryChanges(string catalogObjectId,
        string? locationIds,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/{catalog_object_id}/changes"),
            [new TemplateParam("catalog_object_id", catalogObjectId)],
            [new Param("location_ids", locationIds), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryChangesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveInventoryCount
    /// </summary>
    /// <param name="catalogObjectId">ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> to retrieve.</param>
    /// <param name="locationIds">The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see> IDs to look up as a comma-separated list. An empty list queries all locations.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See the <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see> guide for more information.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryCountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the current calculated stock count for a given
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogObject">CatalogObject</see> at a given set of
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Location">Location</see>s. Responses are paginated and unsorted.
    /// For more sophisticated queries, use a batch endpoint.
    /// </remarks>
    public Task<RetrieveInventoryCountResponse> RetrieveInventoryCount(string catalogObjectId,
        string? locationIds,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/{catalog_object_id}"),
            [new TemplateParam("catalog_object_id", catalogObjectId)],
            [new Param("location_ids", locationIds), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryCountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveInventoryPhysicalCount
    /// </summary>
    /// <param name="physicalCountId">ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount">InventoryPhysicalCount</see> to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryPhysicalCountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryPhysicalCount">InventoryPhysicalCount</see>
    /// object with the provided <c>physical_count_id</c>.
    /// </remarks>
    public Task<RetrieveInventoryPhysicalCountResponse> RetrieveInventoryPhysicalCount(string physicalCountId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/physical-counts/{physical_count_id}"),
            [new TemplateParam("physical_count_id", physicalCountId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryPhysicalCountResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveInventoryTransfer
    /// </summary>
    /// <param name="transferId">ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryTransfer">InventoryTransfer</see> to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveInventoryTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/InventoryTransfer">InventoryTransfer</see> object
    /// with the provided <c>transfer_id</c>.
    /// </remarks>
    public Task<RetrieveInventoryTransferResponse> RetrieveInventoryTransfer(string transferId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/inventory/transfers/{transfer_id}"),
            [new TemplateParam("transfer_id", transferId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveInventoryTransferResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
