using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The list of possible reasons why a cardholder might initiate a
/// dispute with their bank.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisputeReason>))]
public sealed record DisputeReason : StringEnum<DisputeReason>
{
    private DisputeReason(string value) : base(value)
    {
    }

    /// <summary>
    /// The cardholder claims that they were charged the wrong amount for the purchase.
    /// To challenge this dispute, provide specific and concrete evidence that the cardholder agreed
    /// to the amount charged.
    /// </summary>
    public static readonly DisputeReason AmountDiffers = new("AMOUNT_DIFFERS");

    /// <summary>
    /// The cardholder claims that they attempted to return the goods or cancel the service.
    /// To challenge this dispute, provide specific and concrete evidence to prove that the cardholder
    /// is not due a refund and that the cardholder acknowledged your cancellation policy.
    /// </summary>
    public static readonly DisputeReason Cancelled = new("CANCELLED");

    /// <summary>
    /// The cardholder claims that they were charged twice for the same purchase.
    /// To challenge this dispute, provide specific and concrete evidence that shows both charges are
    /// legitimate and independent of one another.
    /// </summary>
    public static readonly DisputeReason Duplicate = new("DUPLICATE");

    /// <summary>
    /// The cardholder claims that they did not make this purchase nor authorized the charge.
    /// To challenge this dispute, provide specific and concrete evidence that proves that the cardholder
    /// identity was verified at the time of purchase and that the purchase was authorized.
    /// </summary>
    public static readonly DisputeReason NoKnowledge = new("NO_KNOWLEDGE");

    /// <summary>
    /// The cardholder claims the product or service was provided, but the quality of the deliverable
    /// did not align with the expectations of the cardholder based on the description.
    /// To challenge this dispute, provide specific and concrete evidence that shows the cardholder is in
    /// possession of the product as described or received the service as described and agreed on.
    /// </summary>
    public static readonly DisputeReason NotAsDescribed = new("NOT_AS_DESCRIBED");

    /// <summary>
    /// The cardholder claims the product or service was not received by the cardholder within the
    /// stated time frame.
    /// To challenge this dispute, provide specific and concrete evidence to prove that the cardholder is
    /// in possession of or received the product or service sold.
    /// </summary>
    public static readonly DisputeReason NotReceived = new("NOT_RECEIVED");

    /// <summary>
    /// The cardholder claims that they previously paid for this purchase.
    /// To challenge this dispute, provide specific and concrete evidence that shows both charges are
    /// legitimate and independent of one another or proof that you already provided a credit for the charge.
    /// </summary>
    public static readonly DisputeReason PaidByOtherMeans = new("PAID_BY_OTHER_MEANS");

    /// <summary>
    /// The cardholder claims that the purchase was canceled or returned, but they have not yet received
    /// the credit.
    /// To challenge this dispute, provide specific and concrete evidence to prove that the cardholder is not
    /// due a refund and that they acknowledged your cancellation and/or refund policy.
    /// </summary>
    public static readonly DisputeReason CustomerRequestsCredit = new("CUSTOMER_REQUESTS_CREDIT");

    /// <summary>
    /// A chip-enabled card was not processed through a compliant chip-card reader (for example, it was swiped
    /// instead of dipped into a chip-card reader).
    /// You cannot challenge this dispute because the payment did not comply with EMV security requirements.
    /// For more information, see <see href="https://squareup.com/emv">What Is EMV?</see>
    /// </summary>
    public static readonly DisputeReason EmvLiabilityShift = new("EMV_LIABILITY_SHIFT");

    public static DisputeReason FromValue(string value) => FromValueCore(value);
}
