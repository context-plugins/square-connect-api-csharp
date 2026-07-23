using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The possible subscription event info codes.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionEventInfoCode>))]
public sealed record SubscriptionEventInfoCode : StringEnum<SubscriptionEventInfoCode>
{
    private SubscriptionEventInfoCode(string value) : base(value)
    {
    }

    /// <summary>
    /// The location is not active.
    /// </summary>
    public static readonly SubscriptionEventInfoCode LocationNotActive = new("LOCATION_NOT_ACTIVE");

    /// <summary>
    /// The location cannot accept payments.
    /// </summary>
    public static readonly SubscriptionEventInfoCode LocationCannotAcceptPayment = new("LOCATION_CANNOT_ACCEPT_PAYMENT");

    /// <summary>
    /// The customer has been deleted.
    /// </summary>
    public static readonly SubscriptionEventInfoCode CustomerDeleted = new("CUSTOMER_DELETED");

    /// <summary>
    /// The customer doesn't have an email.
    /// </summary>
    public static readonly SubscriptionEventInfoCode CustomerNoEmail = new("CUSTOMER_NO_EMAIL");

    /// <summary>
    /// The customer doesn't have a name.
    /// </summary>
    public static readonly SubscriptionEventInfoCode CustomerNoName = new("CUSTOMER_NO_NAME");

    public static SubscriptionEventInfoCode FromValue(string value) => FromValueCore(value);
}
