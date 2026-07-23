using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The possible subscription event types.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionEventSubscriptionEventType>))]
public sealed record SubscriptionEventSubscriptionEventType : StringEnum<SubscriptionEventSubscriptionEventType>
{
    private SubscriptionEventSubscriptionEventType(string value) : base(value)
    {
    }

    /// <summary>
    /// The subscription started.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType StartSubscription = new("START_SUBSCRIPTION");

    /// <summary>
    /// The subscription plan changed.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType PlanChange = new("PLAN_CHANGE");

    /// <summary>
    /// The subscription stopped.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType StopSubscription = new("STOP_SUBSCRIPTION");

    /// <summary>
    /// The subscription deactivated
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType DeactivateSubscription = new("DEACTIVATE_SUBSCRIPTION");

    /// <summary>
    /// The subscription resumed.
    /// </summary>
    public static readonly SubscriptionEventSubscriptionEventType ResumeSubscription = new("RESUME_SUBSCRIPTION");

    public static SubscriptionEventSubscriptionEventType FromValue(string value) => FromValueCore(value);
}
