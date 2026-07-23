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

public sealed class CashDrawers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CashDrawers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ListCashDrawerShiftEvents
    /// </summary>
    /// <param name="shiftId">The shift ID.</param>
    /// <param name="locationId">The ID of the location to list cash drawer shifts for.</param>
    /// <param name="limit">Number of resources to be returned in a page of results (200 by default, 1000 max).</param>
    /// <param name="cursor">Opaque cursor for fetching the next page of results.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCashDrawerShiftEventsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides a paginated list of events for a single cash drawer shift.
    /// </remarks>
    public Task<ListCashDrawerShiftEventsResponse> ListCashDrawerShiftEvents(string shiftId,
        string locationId,
        int? limit,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/cash-drawers/shifts/{shift_id}/events"),
            [new TemplateParam("shift_id", shiftId)],
            [new Param("location_id", locationId), new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCashDrawerShiftEventsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListCashDrawerShifts
    /// </summary>
    /// <param name="locationId">The ID of the location to query for a list of cash drawer shifts.</param>
    /// <param name="sortOrder">The order in which cash drawer shifts are listed in the response, based on their opened_at field. Default value: ASC</param>
    /// <param name="beginTime">The inclusive start time of the query on opened_at, in ISO 8601 format.</param>
    /// <param name="endTime">The exclusive end date of the query on opened_at, in ISO 8601 format.</param>
    /// <param name="limit">Number of cash drawer shift events in a page of results (200 by default, 1000 max).</param>
    /// <param name="cursor">Opaque cursor for fetching the next page of results.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCashDrawerShiftsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides the details for all of the cash drawer shifts for a location
    /// in a date range.
    /// </remarks>
    public Task<ListCashDrawerShiftsResponse> ListCashDrawerShifts(string locationId,
        string? sortOrder,
        string? beginTime,
        string? endTime,
        int? limit,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/cash-drawers/shifts"),
            [],
            [new Param("location_id", locationId),
                new Param("sort_order", sortOrder),
                new Param("begin_time", beginTime),
                new Param("end_time", endTime),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCashDrawerShiftsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveCashDrawerShift
    /// </summary>
    /// <param name="shiftId">The shift ID.</param>
    /// <param name="locationId">The ID of the location to retrieve cash drawer shifts from.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCashDrawerShiftResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides the summary details for a single cash drawer shift. See
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/cash-drawers-api/list-cash-drawer-shift-events">ListCashDrawerShiftEvents</see> for a list of cash drawer shift events.
    /// </remarks>
    public Task<RetrieveCashDrawerShiftResponse> RetrieveCashDrawerShift(string shiftId,
        string locationId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/cash-drawers/shifts/{shift_id}"),
            [new TemplateParam("shift_id", shiftId)],
            [new Param("location_id", locationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCashDrawerShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
