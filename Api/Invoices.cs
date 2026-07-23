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

public sealed class Invoices
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Invoices(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CancelInvoice
    /// </summary>
    /// <param name="invoiceId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see> to cancel.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelInvoiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an invoice. The seller cannot collect payments for
    /// the canceled invoice.
    /// <para>
    /// You cannot cancel an invoice in the <c>DRAFT</c> state or in a terminal state: <c>PAID</c>, <c>REFUNDED</c>, <c>CANCELED</c>, or <c>FAILED</c>.
    /// </para>
    /// </remarks>
    public Task<CancelInvoiceResponse> CancelInvoice(string invoiceId,
        CancelInvoiceRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices/{invoice_id}/cancel"),
            [new TemplateParam("invoice_id", invoiceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CancelInvoiceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateInvoice
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateInvoiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a draft <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see>
    /// for an order created using the Orders API.
    /// <para>
    /// A draft invoice remains in your account and no action is taken.
    /// You must publish the invoice before Square can process it (send it to the customer's email address or charge the customer’s card on file).
    /// </para>
    /// </remarks>
    public Task<CreateInvoiceResponse> CreateInvoice(CreateInvoiceRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateInvoiceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteInvoice
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to delete.</param>
    /// <param name="version">The version of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Invoice">invoice</see> to delete. If you do not know the version, you can call <see href="https://developer.squareup.com/reference/square_2021-08-18/invoices-api/get-invoice">GetInvoice</see> or  <see href="https://developer.squareup.com/reference/square_2021-08-18/invoices-api/list-invoices">ListInvoices</see>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteInvoiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the specified invoice. When an invoice is deleted, the
    /// associated order status changes to CANCELED. You can only delete a draft
    /// invoice (you cannot delete a published invoice, including one that is scheduled for processing).
    /// </remarks>
    public Task<DeleteInvoiceResponse> DeleteInvoice(string invoiceId, int? version, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices/{invoice_id}"),
            [new TemplateParam("invoice_id", invoiceId)],
            [new Param("version", version)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteInvoiceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// GetInvoice
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetInvoiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves an invoice by invoice ID.
    /// </remarks>
    public Task<GetInvoiceResponse> GetInvoice(string invoiceId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices/{invoice_id}"),
            [new TemplateParam("invoice_id", invoiceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetInvoiceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListInvoices
    /// </summary>
    /// <param name="locationId">The ID of the location for which to list invoices.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint.  Provide this cursor to retrieve the next set of results for your original query.  For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Pagination</see>.</param>
    /// <param name="limit">The maximum number of invoices to return (200 is the maximum <c>limit</c>).  If not provided, the server uses a default limit of 100 invoices.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListInvoicesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of invoices for a given location. The response
    /// is paginated. If truncated, the response includes a <c>cursor</c> that you
    /// use in a subsequent request to retrieve the next set of invoices.
    /// </remarks>
    public Task<ListInvoicesResponse> ListInvoices(string locationId,
        string? cursor,
        int? limit,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices"),
            [],
            [new Param("location_id", locationId), new Param("cursor", cursor), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListInvoicesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// PublishInvoice
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to publish.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PublishInvoiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Publishes the specified draft invoice.
    /// <para>
    /// After an invoice is published, Square
    /// follows up based on the invoice configuration. For example, Square
    /// sends the invoice to the customer's email address, charges the customer's card on file, or does
    /// nothing. Square also makes the invoice available on a Square-hosted invoice page.
    /// </para>
    /// <para>
    /// The invoice <c>status</c> also changes from <c>DRAFT</c> to a status
    /// based on the invoice configuration. For example, the status changes to <c>UNPAID</c> if
    /// Square emails the invoice or <c>PARTIALLY_PAID</c> if Square charge a card on file for a portion of the
    /// invoice amount.
    /// </para>
    /// </remarks>
    public Task<PublishInvoiceResponse> PublishInvoice(string invoiceId,
        PublishInvoiceRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices/{invoice_id}/publish"),
            [new TemplateParam("invoice_id", invoiceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PublishInvoiceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchInvoices
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchInvoicesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for invoices from a location specified in
    /// the filter. You can optionally specify customers in the filter for whom to
    /// retrieve invoices. In the current implementation, you can only specify one location and
    /// optionally one customer.
    /// <para>
    /// The response is paginated. If truncated, the response includes a <c>cursor</c>
    /// that you use in a subsequent request to retrieve the next set of invoices.
    /// </para>
    /// </remarks>
    public Task<SearchInvoicesResponse> SearchInvoices(SearchInvoicesRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchInvoicesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateInvoice
    /// </summary>
    /// <param name="invoiceId">The ID of the invoice to update.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateInvoiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an invoice by modifying fields, clearing fields, or both. For most updates, you can use a sparse
    /// <c>Invoice</c> object to add fields or change values and use the <c>fields_to_clear</c> field to specify fields to clear.
    /// However, some restrictions apply. For example, you cannot change the <c>order_id</c> or <c>location_id</c> field and you
    /// must provide the complete <c>custom_fields</c> list to update a custom field. Published invoices have additional restrictions.
    /// </remarks>
    public Task<UpdateInvoiceResponse> UpdateInvoice(string invoiceId,
        UpdateInvoiceRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/invoices/{invoice_id}"),
            [new TemplateParam("invoice_id", invoiceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateInvoiceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
