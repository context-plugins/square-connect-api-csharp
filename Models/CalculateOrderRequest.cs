using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record CalculateOrderRequest
{
    /// <summary>
    /// Contains all information related to a single order to process with Square,
    /// including line items that specify the products to purchase. <c>Order</c> objects also
    /// include information about any associated tenders, refunds, and returns.
    /// <para>
    /// All Connect V2 Transactions have all been converted to Orders including all associated
    /// itemization data.
    /// </para>
    /// </summary>
    [JsonPropertyName("order")]
    public required Order Order { get; init; }

    /// <summary>
    /// Identifies one or more loyalty reward tiers to apply during the order calculation.
    /// The discounts defined by the reward tiers are added to the order only to preview the
    /// effect of applying the specified rewards. The rewards do not correspond to actual
    /// redemptions; that is, no <c>reward</c>s are created. Therefore, the reward <c>id</c>s are
    /// random strings used only to reference the reward tier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("proposed_rewards")]
    public IReadOnlyList<OrderReward>? ProposedRewards { get; init; }
}
