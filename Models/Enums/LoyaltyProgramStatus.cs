using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates whether the program is currently active.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramStatus>))]
public sealed record LoyaltyProgramStatus : StringEnum<LoyaltyProgramStatus>
{
    private LoyaltyProgramStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The loyalty program does not have an active subscription.
    /// Loyalty API requests fail.
    /// </summary>
    public static readonly LoyaltyProgramStatus Inactive = new("INACTIVE");

    /// <summary>
    /// The program is fully functional. The program has an active subscription.
    /// </summary>
    public static readonly LoyaltyProgramStatus Active = new("ACTIVE");

    public static LoyaltyProgramStatus FromValue(string value) => FromValueCore(value);
}
