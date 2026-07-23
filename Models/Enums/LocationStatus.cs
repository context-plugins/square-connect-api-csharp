using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The status of the location, whether a location is active or inactive.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LocationStatus>))]
public sealed record LocationStatus : StringEnum<LocationStatus>
{
    private LocationStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// A location that is active for business.
    /// </summary>
    public static readonly LocationStatus Active = new("ACTIVE");

    /// <summary>
    /// A location that is not active for business. Inactive locations just provide historical
    /// information, so typically clients limit interaction with or hide these locations.
    /// </summary>
    public static readonly LocationStatus Inactive = new("INACTIVE");

    public static LocationStatus FromValue(string value) => FromValueCore(value);
}
