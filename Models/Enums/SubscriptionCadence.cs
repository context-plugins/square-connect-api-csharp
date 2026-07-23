using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Determines the billing cadence of a <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Subscription">Subscription</see>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubscriptionCadence>))]
public sealed record SubscriptionCadence : StringEnum<SubscriptionCadence>
{
    private SubscriptionCadence(string value) : base(value)
    {
    }

    /// <summary>
    /// Once per day
    /// </summary>
    public static readonly SubscriptionCadence Daily = new("DAILY");

    /// <summary>
    /// Once per week
    /// </summary>
    public static readonly SubscriptionCadence Weekly = new("WEEKLY");

    /// <summary>
    /// Every two weeks
    /// </summary>
    public static readonly SubscriptionCadence EveryTwoWeeks = new("EVERY_TWO_WEEKS");

    /// <summary>
    /// Once every 30 days
    /// </summary>
    public static readonly SubscriptionCadence ThirtyDays = new("THIRTY_DAYS");

    /// <summary>
    /// Once every 60 days
    /// </summary>
    public static readonly SubscriptionCadence SixtyDays = new("SIXTY_DAYS");

    /// <summary>
    /// Once every 90 days
    /// </summary>
    public static readonly SubscriptionCadence NinetyDays = new("NINETY_DAYS");

    /// <summary>
    /// Once per month
    /// </summary>
    public static readonly SubscriptionCadence Monthly = new("MONTHLY");

    /// <summary>
    /// Once every two months
    /// </summary>
    public static readonly SubscriptionCadence EveryTwoMonths = new("EVERY_TWO_MONTHS");

    /// <summary>
    /// Once every three months
    /// </summary>
    public static readonly SubscriptionCadence Quarterly = new("QUARTERLY");

    /// <summary>
    /// Once every four months
    /// </summary>
    public static readonly SubscriptionCadence EveryFourMonths = new("EVERY_FOUR_MONTHS");

    /// <summary>
    /// Once every six months
    /// </summary>
    public static readonly SubscriptionCadence EverySixMonths = new("EVERY_SIX_MONTHS");

    /// <summary>
    /// Once per year
    /// </summary>
    public static readonly SubscriptionCadence Annual = new("ANNUAL");

    /// <summary>
    /// Once every two years
    /// </summary>
    public static readonly SubscriptionCadence EveryTwoYears = new("EVERY_TWO_YEARS");

    public static SubscriptionCadence FromValue(string value) => FromValueCore(value);
}
