using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Enumerates the possible assignment types that the team member can have.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TeamMemberAssignedLocationsAssignmentType>))]
public sealed record TeamMemberAssignedLocationsAssignmentType : StringEnum<TeamMemberAssignedLocationsAssignmentType>
{
    private TeamMemberAssignedLocationsAssignmentType(string value) : base(value)
    {
    }

    /// <summary>
    /// The team member is assigned to all current and future locations. The <c>location_ids</c> field
    /// is empty if the team member has this assignment type.
    /// </summary>
    public static readonly TeamMemberAssignedLocationsAssignmentType AllCurrentAndFutureLocations = new("ALL_CURRENT_AND_FUTURE_LOCATIONS");

    /// <summary>
    /// The team member is assigned to an explicit subset of locations. The <c>location_ids</c> field
    /// is the list of locations that the team member is assigned to.
    /// </summary>
    public static readonly TeamMemberAssignedLocationsAssignmentType ExplicitLocations = new("EXPLICIT_LOCATIONS");

    public static TeamMemberAssignedLocationsAssignmentType FromValue(string value) => FromValueCore(value);
}
