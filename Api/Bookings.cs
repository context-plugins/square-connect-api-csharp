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

public sealed class Bookings
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Bookings(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// CancelBooking
    /// </summary>
    /// <param name="bookingId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Booking">Booking</see> object representing the to-be-cancelled booking.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an existing booking.
    /// </remarks>
    public Task<CancelBookingResponse> CancelBooking(string bookingId,
        CancelBookingRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}/cancel"),
            [new TemplateParam("booking_id", bookingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CancelBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// CreateBooking
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a booking.
    /// </remarks>
    public Task<CreateBookingResponse> CreateBooking(CreateBookingRequest body, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// ListTeamMemberBookingProfiles
    /// </summary>
    /// <param name="bookableOnly">Indicates whether to include only bookable team members in the returned result (<c>true</c>) or not (<c>false</c>).</param>
    /// <param name="limit">The maximum number of results to return.</param>
    /// <param name="cursor">The cursor for paginating through the results.</param>
    /// <param name="locationId">Indicates whether to include only team members enabled at the given location in the returned result.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListTeamMemberBookingProfilesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists booking profiles for team members.
    /// </remarks>
    public Task<ListTeamMemberBookingProfilesResponse> ListTeamMemberBookingProfiles(bool? bookableOnly,
        int? limit,
        string? cursor,
        string? locationId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/team-member-booking-profiles"),
            [],
            [new Param("bookable_only", bookableOnly),
                new Param("limit", limit),
                new Param("cursor", cursor),
                new Param("location_id", locationId)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListTeamMemberBookingProfilesResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveBooking
    /// </summary>
    /// <param name="bookingId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Booking">Booking</see> object representing the to-be-retrieved booking.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a booking.
    /// </remarks>
    public Task<RetrieveBookingResponse> RetrieveBooking(string bookingId, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}"),
            [new TemplateParam("booking_id", bookingId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveBusinessBookingProfile
    /// </summary>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveBusinessBookingProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a seller's booking profile.
    /// </remarks>
    public Task<RetrieveBusinessBookingProfileResponse> RetrieveBusinessBookingProfile(CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/business-booking-profile"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveBusinessBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// RetrieveTeamMemberBookingProfile
    /// </summary>
    /// <param name="teamMemberId">The ID of the team member to retrieve.</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RetrieveTeamMemberBookingProfileResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a team member's booking profile.
    /// </remarks>
    public Task<RetrieveTeamMemberBookingProfileResponse> RetrieveTeamMemberBookingProfile(string teamMemberId,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/team-member-booking-profiles/{team_member_id}"),
            [new TemplateParam("team_member_id", teamMemberId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RetrieveTeamMemberBookingProfileResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// SearchAvailability
    /// </summary>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SearchAvailabilityResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Searches for availabilities for booking.
    /// </remarks>
    public Task<SearchAvailabilityResponse> SearchAvailability(SearchAvailabilityRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/availability/search"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SearchAvailabilityResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);

    /// <summary>
    /// UpdateBooking
    /// </summary>
    /// <param name="bookingId">The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Booking">Booking</see> object representing the to-be-updated booking.</param>
    /// <param name="body"></param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateBookingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a booking.
    /// </remarks>
    public Task<UpdateBookingResponse> UpdateBooking(string bookingId,
        UpdateBookingRequest body,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/bookings/{booking_id}"),
            [new TemplateParam("booking_id", bookingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<UpdateBookingResponse>(),
            RawErrorResponse.Instance,
            [_auth.Oauth2],
            ct);
}
