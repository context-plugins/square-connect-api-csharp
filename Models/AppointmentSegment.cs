using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SquareConnectApi.Core.Validation.Attributes;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines an appointment segment of a booking.
/// </summary>
public record AppointmentSegment
{
    /// <summary>
    /// The time span in minutes of an appointment segment.
    /// </summary>
    [JsonPropertyName("duration_minutes")]
    [Minimum(0)]
    [Maximum(1500)]
    public required int DurationMinutes { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see> object representing the service booked in this segment.
    /// </summary>
    [JsonPropertyName("service_variation_id")]
    [MinLength(1)]
    public required string ServiceVariationId { get; init; }

    /// <summary>
    /// The current version of the item variation representing the service booked in this segment.
    /// </summary>
    [JsonPropertyName("service_variation_version")]
    public required long ServiceVariationVersion { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/TeamMember">TeamMember</see> object representing the team member booked in this segment.
    /// </summary>
    [JsonPropertyName("team_member_id")]
    [MinLength(1)]
    public required string TeamMemberId { get; init; }
}
