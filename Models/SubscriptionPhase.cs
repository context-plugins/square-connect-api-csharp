using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a phase in a subscription plan. For more information, see
/// <see href="https://developer.squareup.com/docs/subscriptions-api/setup-plan">Set Up and Manage a Subscription Plan</see>.
/// </summary>
public record SubscriptionPhase
{
    /// <summary>
    /// The billing cadence of the phase. For example, weekly or monthly. This field cannot be changed after a <c>SubscriptionPhase</c> is created.
    /// </summary>
    [JsonPropertyName("cadence")]
    public required string Cadence { get; init; }

    /// <summary>
    /// The position this phase appears in the sequence of phases defined for the plan, indexed from 0. This field cannot be changed after a <c>SubscriptionPhase</c> is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ordinal")]
    public long? Ordinal { get; init; }

    /// <summary>
    /// The number of <c>cadence</c>s the phase lasts. If not set, the phase never ends. Only the last phase can be indefinite. This field cannot be changed after a <c>SubscriptionPhase</c> is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("periods")]
    public int? Periods { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("recurring_price_money")]
    public required Money RecurringPriceMoney { get; init; }

    /// <summary>
    /// The Square-assigned ID of the subscription phase. This field cannot be changed after a <c>SubscriptionPhase</c> is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    public string? Uid { get; init; }
}
