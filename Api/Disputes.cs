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

public sealed class Disputes
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Disputes(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// AcceptDispute
    /// </summary>
    /// <param name="disputeId">The ID of the dispute you want to accept.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AcceptDisputeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accepts the loss on a dispute. Square returns the disputed amount to the cardholder and
    /// updates the dispute state to ACCEPTED.
    /// <para>
    /// Square debits the disputed amount from the seller’s Square account. If the Square account
    /// does not have sufficient funds, Square debits the associated bank account.
    /// </para>
    /// </remarks>
    public Task<AcceptDisputeResponse> AcceptDispute(string disputeId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/accept"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<AcceptDisputeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateDisputeEvidenceText
    /// </summary>
    /// <param name="disputeId">The ID of the dispute you want to upload evidence for.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateDisputeEvidenceTextResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads text to use as evidence for a dispute challenge.
    /// </remarks>
    public Task<CreateDisputeEvidenceTextResponse> CreateDisputeEvidenceText(string disputeId,
        CreateDisputeEvidenceTextRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence-text"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateDisputeEvidenceTextResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// DeleteDisputeEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute you want to remove evidence from.</param>
    /// <param name="evidenceId">The ID of the evidence you want to remove.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes specified evidence from a dispute.
    /// <para>
    /// Square does not send the bank any evidence that is removed. Also, you cannot remove evidence after
    /// submitting it to the bank using <see href="https://developer.squareup.com/reference/square_2021-08-18/disputes-api/submit-evidence">SubmitEvidence</see>.
    /// </para>
    /// </remarks>
    public Task<DeleteDisputeEvidenceResponse> DeleteDisputeEvidence(string disputeId,
        string evidenceId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence/{evidence_id}"),
            [new TemplateParam("dispute_id", disputeId), new TemplateParam("evidence_id", evidenceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<DeleteDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListDisputeEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute.</param>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of evidence associated with a dispute.
    /// </remarks>
    public Task<ListDisputeEvidenceResponse> ListDisputeEvidence(string disputeId,
        string? cursor,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence"),
            [new TemplateParam("dispute_id", disputeId)],
            [new Param("cursor", cursor)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListDisputes
    /// </summary>
    /// <param name="cursor">A pagination cursor returned by a previous call to this endpoint. Provide this cursor to retrieve the next set of results for the original query. For more information, see <see href="https://developer.squareup.com/docs/basics/api101/pagination">Pagination</see>.</param>
    /// <param name="states">The dispute states to filter the result. If not specified, the endpoint returns all open disputes (the dispute status is not <c>INQUIRY_CLOSED</c>, <c>WON</c>, or <c>LOST</c>).</param>
    /// <param name="locationId">The ID of the location for which to return a list of disputes. If not specified, the endpoint returns all open disputes (the dispute status is not <c>INQUIRY_CLOSED</c>, <c>WON</c>, or <c>LOST</c>) associated with all locations.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDisputesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of disputes associated with a particular account.
    /// </remarks>
    public Task<ListDisputesResponse> ListDisputes(string? cursor,
        string? states,
        string? locationId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes"),
            [],
            [new Param("cursor", cursor), new Param("states", states), new Param("location_id", locationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDisputesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveDispute
    /// </summary>
    /// <param name="disputeId">The ID of the dispute you want more details about.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveDisputeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns details about a specific dispute.
    /// </remarks>
    public Task<RetrieveDisputeResponse> RetrieveDispute(string disputeId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveDisputeResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveDisputeEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute that you want to retrieve evidence from.</param>
    /// <param name="evidenceId">The ID of the evidence to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveDisputeEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the evidence metadata specified by the evidence ID in the request URL path
    /// <para>
    /// You must maintain a copy of the evidence you upload if you want to reference it later. You cannot
    /// download the evidence after you upload it.
    /// </para>
    /// </remarks>
    public Task<RetrieveDisputeEvidenceResponse> RetrieveDisputeEvidence(string disputeId,
        string evidenceId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/evidence/{evidence_id}"),
            [new TemplateParam("dispute_id", disputeId), new TemplateParam("evidence_id", evidenceId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveDisputeEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SubmitEvidence
    /// </summary>
    /// <param name="disputeId">The ID of the dispute that you want to submit evidence for.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubmitEvidenceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Submits evidence to the cardholder's bank.
    /// <para>
    /// Before submitting evidence, Square compiles all available evidence. This includes evidence uploaded
    /// using the <see href="https://developer.squareup.com/reference/square_2021-08-18/disputes-api/create-dispute-evidence-file">CreateDisputeEvidenceFile</see> and
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/disputes-api/create-dispute-evidence-text">CreateDisputeEvidenceText</see> endpoints and
    /// evidence automatically provided by Square, when available.
    /// </para>
    /// </remarks>
    public Task<SubmitEvidenceResponse> SubmitEvidence(string disputeId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/disputes/{dispute_id}/submit-evidence"),
            [new TemplateParam("dispute_id", disputeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<SubmitEvidenceResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
