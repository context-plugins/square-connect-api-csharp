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

public sealed class Labor
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Labor(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateBreakType
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateBreakTypeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new <c>BreakType</c>.
    /// <para>
    /// A <c>BreakType</c> is a template for creating <c>Break</c> objects.
    /// You must provide the following values in your request to this
    /// endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>location_id</c></description></item>
    ///   <item><description><c>break_name</c></description></item>
    ///   <item><description><c>expected_duration</c></description></item>
    ///   <item><description><c>is_paid</c></description></item>
    /// </list>
    /// <para>
    /// You can only have three <c>BreakType</c> instances per location. If you attempt to add a fourth
    /// <c>BreakType</c> for a location, an <c>INVALID_REQUEST_ERROR</c> "Exceeded limit of 3 breaks per location."
    /// is returned.
    /// </para>
    /// </remarks>
    public Task<CreateBreakTypeResponse> CreateBreakType(CreateBreakTypeRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/break-types"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateShift
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateShiftResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new <c>Shift</c>.
    /// <para>
    /// A <c>Shift</c> represents a complete workday for a single employee.
    /// You must provide the following values in your request to this
    /// endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>location_id</c></description></item>
    ///   <item><description><c>employee_id</c></description></item>
    ///   <item><description><c>start_at</c></description></item>
    /// </list>
    /// <para>
    /// An attempt to create a new <c>Shift</c> can result in a <c>BAD_REQUEST</c> error when:
    /// - The <c>status</c> of the new <c>Shift</c> is <c>OPEN</c> and the employee has another
    /// shift with an <c>OPEN</c> status.
    /// - The <c>start_at</c> date is in the future.
    /// - The <c>start_at</c> or <c>end_at</c> date overlaps another shift for the same employee.
    /// - The <c>Break</c> instances are set in the request and a break <c>start_at</c>
    /// is before the <c>Shift.start_at</c>, a break <c>end_at</c> is after
    /// the <c>Shift.end_at</c>, or both.
    /// </para>
    /// </remarks>
    public Task<CreateShiftResponse> CreateShift(CreateShiftRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/shifts"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteBreakType
    /// </summary>
    /// <param name="id">The UUID for the <c>BreakType</c> being deleted.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteBreakTypeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an existing <c>BreakType</c>.
    /// <para>
    /// A <c>BreakType</c> can be deleted even if it is referenced from a <c>Shift</c>.
    /// </para>
    /// </remarks>
    public Task<DeleteBreakTypeResponse> DeleteBreakType(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/break-types/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteShift
    /// </summary>
    /// <param name="id">The UUID for the <c>Shift</c> being deleted.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteShiftResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a <c>Shift</c>.
    /// </remarks>
    public Task<DeleteShiftResponse> DeleteShift(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/shifts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetBreakType
    /// </summary>
    /// <param name="id">The UUID for the <c>BreakType</c> being retrieved.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetBreakTypeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>BreakType</c> specified by <c>id</c>.
    /// </remarks>
    public Task<GetBreakTypeResponse> GetBreakType(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/break-types/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetEmployeeWage
    /// </summary>
    /// <param name="id">The UUID for the <c>EmployeeWage</c> being retrieved.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetEmployeeWageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>EmployeeWage</c> specified by <c>id</c>.
    /// </remarks>
    public Task<GetEmployeeWageResponse> GetEmployeeWage(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/employee-wages/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetEmployeeWageResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetShift
    /// </summary>
    /// <param name="id">The UUID for the <c>Shift</c> being retrieved.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetShiftResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>Shift</c> specified by <c>id</c>.
    /// </remarks>
    public Task<GetShiftResponse> GetShift(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/shifts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetTeamMemberWage
    /// </summary>
    /// <param name="id">The UUID for the <c>TeamMemberWage</c> being retrieved.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTeamMemberWageResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single <c>TeamMemberWage</c> specified by <c>id </c>.
    /// </remarks>
    public Task<GetTeamMemberWageResponse> GetTeamMemberWage(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/team-member-wages/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTeamMemberWageResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListBreakTypes
    /// </summary>
    /// <param name="locationId">Filter the returned <c>BreakType</c> results to only those that are associated with the specified location.</param>
    /// <param name="limit">The maximum number of <c>BreakType</c> results to return per page. The number can range between 1 and 200. The default is 200.</param>
    /// <param name="cursor">A pointer to the next page of <c>BreakType</c> results to fetch.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListBreakTypesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>BreakType</c> instances for a business.
    /// </remarks>
    public Task<ListBreakTypesResponse> ListBreakTypes(string? locationId,
        int? limit,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/break-types"),
            [],
            [new Param("location_id", locationId), new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListBreakTypesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListEmployeeWages
    /// </summary>
    /// <param name="employeeId">Filter the returned wages to only those that are associated with the specified employee.</param>
    /// <param name="limit">The maximum number of <c>EmployeeWage</c> results to return per page. The number can range between 1 and 200. The default is 200.</param>
    /// <param name="cursor">A pointer to the next page of <c>EmployeeWage</c> results to fetch.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListEmployeeWagesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>EmployeeWage</c> instances for a business.
    /// </remarks>
    public Task<ListEmployeeWagesResponse> ListEmployeeWages(string? employeeId,
        int? limit,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/employee-wages"),
            [],
            [new Param("employee_id", employeeId), new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListEmployeeWagesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListTeamMemberWages
    /// </summary>
    /// <param name="teamMemberId">Filter the returned wages to only those that are associated with the specified team member.</param>
    /// <param name="limit">The maximum number of <c>TeamMemberWage</c> results to return per page. The number can range between 1 and 200. The default is 200.</param>
    /// <param name="cursor">A pointer to the next page of <c>EmployeeWage</c> results to fetch.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTeamMemberWagesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>TeamMemberWage</c> instances for a business.
    /// </remarks>
    public Task<ListTeamMemberWagesResponse> ListTeamMemberWages(string? teamMemberId,
        int? limit,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/team-member-wages"),
            [],
            [new Param("team_member_id", teamMemberId), new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTeamMemberWagesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListWorkweekConfigs
    /// </summary>
    /// <param name="limit">The maximum number of <c>WorkweekConfigs</c> results to return per page.</param>
    /// <param name="cursor">A pointer to the next page of <c>WorkweekConfig</c> results to fetch.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListWorkweekConfigsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of <c>WorkweekConfig</c> instances for a business.
    /// </remarks>
    public Task<ListWorkweekConfigsResponse> ListWorkweekConfigs(int? limit,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/workweek-configs"),
            [],
            [new Param("limit", limit), new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListWorkweekConfigsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchShifts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchShiftsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of <c>Shift</c> records for a business.
    /// The list to be returned can be filtered by:
    /// - Location IDs.
    /// - Employee IDs.
    /// - Shift status (<c>OPEN</c> and <c>CLOSED</c>).
    /// - Shift start.
    /// - Shift end.
    /// - Workday details.
    /// <para>
    /// The list can be sorted by:
    /// - <c>start_at</c>.
    /// - <c>end_at</c>.
    /// - <c>created_at</c>.
    /// - <c>updated_at</c>.
    /// </para>
    /// </remarks>
    public Task<SearchShiftsResponse> SearchShifts(SearchShiftsRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/shifts/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchShiftsResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateBreakType
    /// </summary>
    /// <param name="id">The UUID for the <c>BreakType</c> being updated.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateBreakTypeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing <c>BreakType</c>.
    /// </remarks>
    public Task<UpdateBreakTypeResponse> UpdateBreakType(string id,
        UpdateBreakTypeRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/break-types/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateBreakTypeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateShift
    /// </summary>
    /// <param name="id">The ID of the object being updated.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateShiftResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing <c>Shift</c>.
    /// <para>
    /// When adding a <c>Break</c> to a <c>Shift</c>, any earlier <c>Break</c> instances in the <c>Shift</c> have
    /// the <c>end_at</c> property set to a valid RFC-3339 datetime string.
    /// </para>
    /// <para>
    /// When closing a <c>Shift</c>, all <c>Break</c> instances in the <c>Shift</c> must be complete with <c>end_at</c>
    /// set on each <c>Break</c>.
    /// </para>
    /// </remarks>
    public Task<UpdateShiftResponse> UpdateShift(string id, UpdateShiftRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/shifts/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateShiftResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateWorkweekConfig
    /// </summary>
    /// <param name="id">The UUID for the <c>WorkweekConfig</c> object being updated.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateWorkweekConfigResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a <c>WorkweekConfig</c>.
    /// </remarks>
    public Task<UpdateWorkweekConfigResponse> UpdateWorkweekConfig(string id,
        UpdateWorkweekConfigRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/labor/workweek-configs/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateWorkweekConfigResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
