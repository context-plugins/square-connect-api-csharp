using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Enumerates the possible statuses the team member can have within a business.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TeamMemberStatus>))]
public sealed record TeamMemberStatus : StringEnum<TeamMemberStatus>
{
    private TeamMemberStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The team member can sign in to Point of Sale and the Seller Dashboard.
    /// </summary>
    public static readonly TeamMemberStatus Active = new("ACTIVE");

    /// <summary>
    /// The team member can no longer sign in to Point of Sale or the Seller Dashboard,
    /// but the team member's sales reports remain available.
    /// </summary>
    public static readonly TeamMemberStatus Inactive = new("INACTIVE");

    public static TeamMemberStatus FromValue(string value) => FromValueCore(value);
}
