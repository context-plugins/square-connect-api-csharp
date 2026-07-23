using System;
using System.Collections.Generic;
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

public sealed class V1Employees
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal V1Employees(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CreateEmployee
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Employee"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    ///  Use the CreateEmployee endpoint to add an employee to a Square
    /// account. Employees created with the Connect API have an initial status
    /// of <c>INACTIVE</c>. Inactive employees cannot sign in to Square Point of Sale
    /// until they are activated from the Square Dashboard. Employee status
    /// cannot be changed with the Connect API.
    /// <para>
    /// Employee entities cannot be deleted. To disable employee profiles,
    /// set the employee's status to &lt;code&gt;INACTIVE&lt;/code&gt;
    /// </para>
    /// </remarks>
    public Task<V1Employee> CreateEmployee(V1Employee body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/employees"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1Employee>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateEmployeeRole
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1EmployeeRole"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an employee role you can then assign to employees.
    /// <para>
    /// Square accounts can include any number of roles that can be assigned to
    /// employees. These roles define the actions and permissions granted to an
    /// employee with that role. For example, an employee with a "Shift Manager"
    /// role might be able to issue refunds in Square Point of Sale, whereas an
    /// employee with a "Clerk" role might not.
    /// </para>
    /// <para>
    /// Roles are assigned with the <see href="https://developer.squareup.com/reference/square_2021-08-18/v1-employees-api/update-employee-role">V1UpdateEmployee</see>
    /// endpoint. An employee can have only one role at a time.
    /// </para>
    /// <para>
    /// If an employee has no role, they have none of the permissions associated
    /// with roles. All employees can accept payments with Square Point of Sale.
    /// </para>
    /// </remarks>
    public Task<V1EmployeeRole> CreateEmployeeRole(V1EmployeeRole body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/roles"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<V1EmployeeRole>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListEmployeeRoles
    /// </summary>
    /// <param name="order">The order in which employees are listed in the response, based on their created_at field.Default value: ASC</param>
    /// <param name="limit">The maximum integer number of employee entities to return in a single response. Default 100, maximum 200.</param>
    /// <param name="batchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V1EmployeeRole"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides summary information for all of a business's employee roles.
    /// </remarks>
    public Task<IReadOnlyList<V1EmployeeRole>> ListEmployeeRoles(string? order,
        int? limit,
        string? batchToken,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/roles"),
            [],
            [new Param("order", order), new Param("limit", limit), new Param("batch_token", batchToken)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V1EmployeeRole>>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListEmployees
    /// </summary>
    /// <param name="order">The order in which employees are listed in the response, based on their created_at field.      Default value: ASC</param>
    /// <param name="beginUpdatedAt">If filtering results by their updated_at field, the beginning of the requested reporting period, in ISO 8601 format</param>
    /// <param name="endUpdatedAt">If filtering results by there updated_at field, the end of the requested reporting period, in ISO 8601 format.</param>
    /// <param name="beginCreatedAt">If filtering results by their created_at field, the beginning of the requested reporting period, in ISO 8601 format.</param>
    /// <param name="endCreatedAt">If filtering results by their created_at field, the end of the requested reporting period, in ISO 8601 format.</param>
    /// <param name="status">If provided, the endpoint returns only employee entities with the specified status (ACTIVE or INACTIVE).</param>
    /// <param name="externalId">If provided, the endpoint returns only employee entities with the specified external_id.</param>
    /// <param name="limit">The maximum integer number of employee entities to return in a single response. Default 100, maximum 200.</param>
    /// <param name="batchToken">A pagination cursor to retrieve the next set of results for your original query to the endpoint.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V1Employee"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides summary information for all of a business's employees.
    /// </remarks>
    public Task<IReadOnlyList<V1Employee>> ListEmployees(string? order,
        string? beginUpdatedAt,
        string? endUpdatedAt,
        string? beginCreatedAt,
        string? endCreatedAt,
        string? status,
        string? externalId,
        int? limit,
        string? batchToken,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/employees"),
            [],
            [new Param("order", order),
                new Param("begin_updated_at", beginUpdatedAt),
                new Param("end_updated_at", endUpdatedAt),
                new Param("begin_created_at", beginCreatedAt),
                new Param("end_created_at", endCreatedAt),
                new Param("status", status),
                new Param("external_id", externalId),
                new Param("limit", limit),
                new Param("batch_token", batchToken)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V1Employee>>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveEmployee
    /// </summary>
    /// <param name="employeeId">The employee's ID.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Employee"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides the details for a single employee.
    /// </remarks>
    public Task<V1Employee> RetrieveEmployee(string employeeId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/employees/{employee_id}"),
            [new TemplateParam("employee_id", employeeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1Employee>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveEmployeeRole
    /// </summary>
    /// <param name="roleId">The role's ID.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1EmployeeRole"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Provides the details for a single employee role.
    /// </remarks>
    public Task<V1EmployeeRole> RetrieveEmployeeRole(string roleId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/roles/{role_id}"),
            [new TemplateParam("role_id", roleId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<V1EmployeeRole>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateEmployee
    /// </summary>
    /// <param name="employeeId">The ID of the role to modify.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1Employee"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    public Task<V1Employee> UpdateEmployee(string employeeId, V1Employee body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/employees/{employee_id}"),
            [new TemplateParam("employee_id", employeeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1Employee>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateEmployeeRole
    /// </summary>
    /// <param name="roleId">The ID of the role to modify.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="V1EmployeeRole"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Modifies the details of an employee role.
    /// </remarks>
    public Task<V1EmployeeRole> UpdateEmployeeRole(string roleId,
        V1EmployeeRole body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v1/me/roles/{role_id}"),
            [new TemplateParam("role_id", roleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<V1EmployeeRole>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
