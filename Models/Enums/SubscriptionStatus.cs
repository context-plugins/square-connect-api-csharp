using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Possible subscription status values.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionStatus>))]
public sealed record SubscriptionStatus : StringEnum<SubscriptionStatus>
{
    private SubscriptionStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The subscription starts in the future.
    /// </summary>
    public static readonly SubscriptionStatus Pending = new("PENDING");

    /// <summary>
    /// The subscription is active.
    /// </summary>
    public static readonly SubscriptionStatus Active = new("ACTIVE");

    /// <summary>
    /// The subscription is canceled.
    /// </summary>
    public static readonly SubscriptionStatus Canceled = new("CANCELED");

    /// <summary>
    /// The subscription is deactivated.
    /// </summary>
    public static readonly SubscriptionStatus Deactivated = new("DEACTIVATED");

    public static SubscriptionStatus FromValue(string value) => FromValueCore(value);
}
