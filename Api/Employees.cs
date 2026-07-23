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

public sealed class Employees
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Employees(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// ListEmployees
    /// </summary>
    /// <param name="locationId"></param>
    /// <param name="status">Specifies the EmployeeStatus to filter the employee by.</param>
    /// <param name="limit">The number of employees to be returned on each page.</param>
    /// <param name="cursor">The token required to retrieve the specified page of results.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListEmployeesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<ListEmployeesResponse> ListEmployees(string? locationId,
        string? status,
        int? limit,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/employees"),
            [],
            [new Param("location_id", locationId),
                new Param("status", status),
                new Param("limit", limit),
                new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListEmployeesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveEmployee
    /// </summary>
    /// <param name="id">UUID for the employee that was requested.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveEmployeeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<RetrieveEmployeeResponse> RetrieveEmployee(string id, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/employees/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveEmployeeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
