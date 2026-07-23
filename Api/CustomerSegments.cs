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

public sealed class CustomerSegments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CustomerSegments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ListCustomerSegments
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by previous calls to <c>ListCustomerSegments</c>. This cursor is used to retrieve the next set of query results.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.  The limit is ignored if it is less than 1 or greater than 50. The default value is 50.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomerSegmentsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the list of customer segments of a business.
    /// </remarks>
    public Task<ListCustomerSegmentsResponse> ListCustomerSegments(string? cursor,
        int? limit,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/segments"),
            [],
            [new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomerSegmentsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveCustomerSegment
    /// </summary>
    /// <param name="segmentId">The Square-issued ID of the customer segment.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerSegmentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a specific customer segment as identified by the <c>segment_id</c> value.
    /// </remarks>
    public Task<RetrieveCustomerSegmentResponse> RetrieveCustomerSegment(string segmentId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/segments/{segment_id}"),
            [new TemplateParam("segment_id", segmentId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerSegmentResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
