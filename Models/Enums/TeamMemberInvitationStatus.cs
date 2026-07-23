using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Enumerates the possible invitation statuses the team member can have within a business.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TeamMemberInvitationStatus>))]
public sealed record TeamMemberInvitationStatus : StringEnum<TeamMemberInvitationStatus>
{
    private TeamMemberInvitationStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The team member has not received an invitation.
    /// </summary>
    public static readonly TeamMemberInvitationStatus Uninvited = new("UNINVITED");

    /// <summary>
    /// The team member has received an invitation, but had not accepted it.
    /// </summary>
    public static readonly TeamMemberInvitationStatus Pending = new("PENDING");

    /// <summary>
    /// The team member has both received and accepted an invitation.
    /// </summary>
    public static readonly TeamMemberInvitationStatus Accepted = new("ACCEPTED");

    public static TeamMemberInvitationStatus FromValue(string value) => FromValueCore(value);
}
