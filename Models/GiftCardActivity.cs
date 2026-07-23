using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an action performed on a gift card that affects its state or balance.
/// </summary>
public record GiftCardActivity
{
    /// <summary>
    /// Describes a gift card activity of the ACTIVATE type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activate_activity_details")]
    public GiftCardActivityActivate? ActivateActivityDetails { get; init; }

    /// <summary>
    /// Describes a gift card activity of the ADJUST_DECREMENT type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjust_decrement_activity_details")]
    public GiftCardActivityAdjustDecrement? AdjustDecrementActivityDetails { get; init; }

    /// <summary>
    /// Describes a gift card activity of the ADJUST_INCREMENT type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adjust_increment_activity_details")]
    public GiftCardActivityAdjustIncrement? AdjustIncrementActivityDetails { get; init; }

    /// <summary>
    /// Describes a gift card activity of the BLOCK type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("block_activity_details")]
    public GiftCardActivityBlock? BlockActivityDetails { get; init; }

    /// <summary>
    /// Describes a gift card activity of the CLEAR_BALANCE type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clear_balance_activity_details")]
    public GiftCardActivityClearBalance? ClearBalanceActivityDetails { get; init; }

    /// <summary>
    /// The timestamp when the gift card activity was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Describes a gift card activity of the DEACTIVATE type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deactivate_activity_details")]
    public GiftCardActivityDeactivate? DeactivateActivityDetails { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_balance_money")]
    public Money? GiftCardBalanceMoney { get; init; }

    /// <summary>
    /// The gift card GAN. The GAN is not required if <c>gift_card_id</c> is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_gan")]
    public string? GiftCardGan { get; init; }

    /// <summary>
    /// The gift card ID. The ID is not required if a GAN is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gift_card_id")]
    public string? GiftCardId { get; init; }

    /// <summary>
    /// The unique ID of the gift card activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Describes a gift card activity of the IMPORT type and the <c>GiftCardGANSource</c> is OTHER
    /// (a third-party gift card).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("import_activity_details")]
    public GiftCardActivityImport? ImportActivityDetails { get; init; }

    /// <summary>
    /// Present only when GiftCardActivityType is IMPORT_REVERSAL and GiftCardGANSource is OTHER
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("import_reversal_activity_details")]
    public GiftCardActivityImportReversal? ImportReversalActivityDetails { get; init; }

    /// <summary>
    /// Present only when <c>GiftCardActivityType</c> is LOAD.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("load_activity_details")]
    public GiftCardActivityLoad? LoadActivityDetails { get; init; }

    /// <summary>
    /// The ID of the location at which the activity occurred.
    /// </summary>
    [JsonPropertyName("location_id")]
    public required string LocationId { get; init; }

    /// <summary>
    /// Present only when <c>GiftCardActivityType</c> is REDEEM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redeem_activity_details")]
    public GiftCardActivityRedeem? RedeemActivityDetails { get; init; }

    /// <summary>
    /// Present only when <c>GiftCardActivityType</c> is REFUND.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refund_activity_details")]
    public GiftCardActivityRefund? RefundActivityDetails { get; init; }

    [JsonPropertyName("type")]
    public required object Type { get; init; }

    /// <summary>
    /// Present only when <c>GiftCardActivityType</c> is UNBLOCK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unblock_activity_details")]
    public GiftCardActivityUnblock? UnblockActivityDetails { get; init; }

    /// <summary>
    /// Present only when <c>GiftCardActivityType</c> is UNLINKED_ACTIVITY_REFUND.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unlinked_activity_refund_activity_details")]
    public GiftCardActivityUnlinkedActivityRefund? UnlinkedActivityRefundActivityDetails { get; init; }
}
