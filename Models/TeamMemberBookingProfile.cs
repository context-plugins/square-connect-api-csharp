using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The booking profile of a seller's team member, including the team member's ID, display name, description and whether the team member can be booked as a service provider.
/// </summary>
public record TeamMemberBookingProfile
{
    /// <summary>
    /// The description of the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The display name of the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    /// <summary>
    /// Indicates whether the team member can be booked through the Bookings API or the seller's online booking channel or site (<c>true) or not (</c>false`).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_bookable")]
    public bool? IsBookable { get; init; }

    /// <summary>
    /// The URL of the team member's image for the bookings profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profile_image_url")]
    public string? ProfileImageUrl { get; init; }

    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/TeamMember">TeamMember</see> object for the team member associated with the booking profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id")]
    public string? TeamMemberId { get; init; }
}
