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

public sealed class Customers
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Customers(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// AddGroupToCustomer
    /// </summary>
    /// <param name="customerId">The ID of the customer to add to a group.</param>
    /// <param name="groupId">The ID of the customer group to add the customer to.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AddGroupToCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a group membership to a customer.
    /// <para>
    /// The customer is identified by the <c>customer_id</c> value
    /// and the customer group is identified by the <c>group_id</c> value.
    /// </para>
    /// </remarks>
    public Task<AddGroupToCustomerResponse> AddGroupToCustomer(string customerId,
        string groupId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/groups/{group_id}"),
            [new TemplateParam("customer_id", customerId), new TemplateParam("group_id", groupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            EmptyBody.Instance,
            JsonResponse.Create<AddGroupToCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateCustomer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new customer for a business.
    /// <para>
    /// You must provide at least one of the following values in your request to this
    /// endpoint:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>given_name</c></description></item>
    ///   <item><description><c>family_name</c></description></item>
    ///   <item><description><c>company_name</c></description></item>
    ///   <item><description><c>email_address</c></description></item>
    ///   <item><description><c>phone_number</c></description></item>
    /// </list>
    /// </remarks>
    public Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateCustomerCard
    /// </summary>
    /// <param name="customerId">The Square ID of the customer profile the card is linked to.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCustomerCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a card on file to an existing customer.
    /// <para>
    /// As with charges, calls to <c>CreateCustomerCard</c> are idempotent. Multiple
    /// calls with the same card nonce return the same card record that was created
    /// with the provided nonce during the _first_ call.
    /// </para>
    /// </remarks>
    public Task<CreateCustomerCardResponse> CreateCustomerCard(string customerId,
        CreateCustomerCardRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/cards"),
            [new TemplateParam("customer_id", customerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCustomerCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteCustomer
    /// </summary>
    /// <param name="customerId">The ID of the customer to delete.</param>
    /// <param name="version">The current version of the customer profile.  As a best practice, you should include this parameter to enable <see href="https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency">optimistic concurrency</see> control.  For more information, see <see href="https://developer.squareup.com/docs/customers-api/use-the-api/keep-records#delete-customer-profile">Delete a customer profile</see>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a customer profile from a business. This operation also unlinks any associated cards on file.
    /// <para>
    /// As a best practice, you should include the <c>version</c> field in the request to enable <see href="https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency">optimistic concurrency</see> control. The value must be set to the current version of the customer profile.
    /// </para>
    /// <para>
    /// To delete a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.
    /// </para>
    /// </remarks>
    public Task<DeleteCustomerResponse> DeleteCustomer(string customerId,
        long? version,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}"),
            [new TemplateParam("customer_id", customerId)],
            [new Param("version", version)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteCustomerCard
    /// </summary>
    /// <param name="customerId">The ID of the customer that the card on file belongs to.</param>
    /// <param name="cardId">The ID of the card on file to delete.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteCustomerCardResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a card on file from a customer.
    /// </remarks>
    public Task<DeleteCustomerCardResponse> DeleteCustomerCard(string customerId,
        string cardId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/cards/{card_id}"),
            [new TemplateParam("customer_id", customerId), new TemplateParam("card_id", cardId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteCustomerCardResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListCustomers
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for your original query.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="limit">The maximum number of results to return in a single page. This limit is advisory. The response might contain more or fewer results.  The limit is ignored if it is less than 1 or greater than 100. The default value is 100.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="sortField">Indicates how customers should be sorted.  The default value is <c>DEFAULT</c>.</param>
    /// <param name="sortOrder">Indicates whether customers should be sorted in ascending (<c>ASC</c>) or descending (<c>DESC</c>) order.  The default value is <c>ASC</c>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCustomersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists customer profiles associated with a Square account.
    /// <para>
    /// Under normal operating conditions, newly created or updated customer profiles become available
    /// for the listing operation in well under 30 seconds. Occasionally, propagation of the new or updated
    /// profiles can take closer to one minute or longer, especially during network incidents and outages.
    /// </para>
    /// </remarks>
    public Task<ListCustomersResponse> ListCustomers(string? cursor,
        int? limit,
        string? sortField,
        string? sortOrder,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers"),
            [],
            [new Param("cursor", cursor),
                new Param("limit", limit),
                new Param("sort_field", sortField),
                new Param("sort_order", sortOrder)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RemoveGroupFromCustomer
    /// </summary>
    /// <param name="customerId">The ID of the customer to remove from the group.</param>
    /// <param name="groupId">The ID of the customer group to remove the customer from.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RemoveGroupFromCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes a group membership from a customer.
    /// <para>
    /// The customer is identified by the <c>customer_id</c> value
    /// and the customer group is identified by the <c>group_id</c> value.
    /// </para>
    /// </remarks>
    public Task<RemoveGroupFromCustomerResponse> RemoveGroupFromCustomer(string customerId,
        string groupId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}/groups/{group_id}"),
            [new TemplateParam("customer_id", customerId), new TemplateParam("group_id", groupId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<RemoveGroupFromCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveCustomer
    /// </summary>
    /// <param name="customerId">The ID of the customer to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details for a single customer.
    /// </remarks>
    public Task<RetrieveCustomerResponse> RetrieveCustomer(string customerId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}"),
            [new TemplateParam("customer_id", customerId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchCustomers
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchCustomersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches the customer profiles associated with a Square account using a supported query filter.
    /// <para>
    /// Calling <c>SearchCustomers</c> without any explicit query filter returns all
    /// customer profiles ordered alphabetically based on <c>given_name</c> and
    /// <c>family_name</c>.
    /// </para>
    /// <para>
    /// Under normal operating conditions, newly created or updated customer profiles become available
    /// for the search operation in well under 30 seconds. Occasionally, propagation of the new or updated
    /// profiles can take closer to one minute or longer, especially during network incidents and outages.
    /// </para>
    /// </remarks>
    public Task<SearchCustomersResponse> SearchCustomers(SearchCustomersRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchCustomersResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateCustomer
    /// </summary>
    /// <param name="customerId">The ID of the customer to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateCustomerResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a customer profile. To change an attribute, specify the new value. To remove an attribute, specify the value as an empty string or empty object.
    /// <para>
    /// As a best practice, you should include the <c>version</c> field in the request to enable <see href="https://developer.squareup.com/docs/working-with-apis/optimistic-concurrency">optimistic concurrency</see> control. The value must be set to the current version of the customer profile.
    /// </para>
    /// <para>
    /// To update a customer profile that was created by merging existing profiles, you must use the ID of the newly created profile.
    /// </para>
    /// <para>
    /// You cannot use this endpoint to change cards on file. To make changes, use the <see href="https://developer.squareup.com/reference/square_2021-08-18/cards-api">Cards API</see> or <see href="https://developer.squareup.com/reference/square_2021-08-18/gift-cards-api">Gift Cards API</see>.
    /// </para>
    /// </remarks>
    public Task<UpdateCustomerResponse> UpdateCustomer(string customerId,
        UpdateCustomerRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/customers/{customer_id}"),
            [new TemplateParam("customer_id", customerId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateCustomerResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
