using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1SettlementEntryType>))]
public sealed record V1SettlementEntryType : StringEnum<V1SettlementEntryType>
{
    private V1SettlementEntryType(string value) : base(value)
    {
    }

    /// <summary>
    /// A manual adjustment applied to the merchant's account by Square
    /// </summary>
    public static readonly V1SettlementEntryType Adjustment = new("ADJUSTMENT");

    /// <summary>
    /// A payment from an existing Square balance, such as a gift card
    /// </summary>
    public static readonly V1SettlementEntryType BalanceCharge = new("BALANCE_CHARGE");

    /// <summary>
    /// A credit card payment CAPTURE
    /// </summary>
    public static readonly V1SettlementEntryType Charge = new("CHARGE");

    /// <summary>
    /// Square offers Free Payments Processing for a variety of business scenarios including seller referral or when we want to apologize for a bug, customer service, repricing complication, etc. This entry represents a credit to the merchant for the purposes of Free Processing.
    /// </summary>
    public static readonly V1SettlementEntryType FreeProcessing = new("FREE_PROCESSING");

    /// <summary>
    /// An adjustment made by Square related to holding/releasing a payment
    /// </summary>
    public static readonly V1SettlementEntryType HoldAdjustment = new("HOLD_ADJUSTMENT");

    /// <summary>
    /// a fee paid to a 3rd party merchant
    /// </summary>
    public static readonly V1SettlementEntryType PaidServiceFee = new("PAID_SERVICE_FEE");

    /// <summary>
    /// a refund for a 3rd party merchant fee
    /// </summary>
    public static readonly V1SettlementEntryType PaidServiceFeeRefund = new("PAID_SERVICE_FEE_REFUND");

    /// <summary>
    /// Repayment for a redemption code
    /// </summary>
    public static readonly V1SettlementEntryType RedemptionCode = new("REDEMPTION_CODE");

    /// <summary>
    /// A refund for an existing card payment
    /// </summary>
    public static readonly V1SettlementEntryType Refund = new("REFUND");

    /// <summary>
    /// An entry created when we receive a response for the ACH file we sent indicating that the settlement of the original entry failed.
    /// </summary>
    public static readonly V1SettlementEntryType ReturnedPayout = new("RETURNED_PAYOUT");

    /// <summary>
    /// Initial deposit to a merchant for a Capital merchant cash advance (MCA).
    /// </summary>
    public static readonly V1SettlementEntryType SquareCapitalAdvance = new("SQUARE_CAPITAL_ADVANCE");

    /// <summary>
    /// Capital merchant cash advance (MCA) assessment. These are, generally, proportional to the merchant's sales but may be issued for other reasons related to the MCA.
    /// </summary>
    public static readonly V1SettlementEntryType SquareCapitalPayment = new("SQUARE_CAPITAL_PAYMENT");

    /// <summary>
    /// Capital merchant cash advance (MCA) assessment refund. These are, generally, proportional to the merchant's refunds but may be issued for other reasons related to the MCA.
    /// </summary>
    public static readonly V1SettlementEntryType SquareCapitalReversedPayment = new("SQUARE_CAPITAL_REVERSED_PAYMENT");

    /// <summary>
    /// Fee charged for subscription to a Square product
    /// </summary>
    public static readonly V1SettlementEntryType SubscriptionFee = new("SUBSCRIPTION_FEE");

    /// <summary>
    /// Refund of a previously charged Square product subscription fee.
    /// </summary>
    public static readonly V1SettlementEntryType SubscriptionFeeRefund = new("SUBSCRIPTION_FEE_REFUND");

    public static readonly V1SettlementEntryType Other = new("OTHER");

    /// <summary>
    /// A payment in which Square covers part of the funds for a purchase
    /// </summary>
    public static readonly V1SettlementEntryType IncentedPayment = new("INCENTED_PAYMENT");

    /// <summary>
    /// A settlement failed to be processed and the settlement amount has been returned to the account
    /// </summary>
    public static readonly V1SettlementEntryType ReturnedAchEntry = new("RETURNED_ACH_ENTRY");

    /// <summary>
    /// Refund for cancelling a Square Plus subscription
    /// </summary>
    public static readonly V1SettlementEntryType ReturnedSquare275 = new("RETURNED_SQUARE_275");

    /// <summary>
    /// Fee charged for a Square Plus subscription ($275)
    /// </summary>
    public static readonly V1SettlementEntryType Square275 = new("SQUARE_275");

    /// <summary>
    /// Settlements to or withdrawals from the Square Card (an asset)
    /// </summary>
    public static readonly V1SettlementEntryType SquareCard = new("SQUARE_CARD");

    public static V1SettlementEntryType FromValue(string value) => FromValueCore(value);
}
