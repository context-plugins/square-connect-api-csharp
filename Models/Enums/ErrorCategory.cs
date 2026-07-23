using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates which high-level category of error has occurred during a
/// request to the Connect API.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorCategory>))]
public sealed record ErrorCategory : StringEnum<ErrorCategory>
{
    private ErrorCategory(string value) : base(value)
    {
    }

    /// <summary>
    /// An error occurred with the Connect API itself.
    /// </summary>
    public static readonly ErrorCategory ApiError = new("API_ERROR");

    /// <summary>
    /// An authentication error occurred. Most commonly, the request had
    /// a missing, malformed, or otherwise invalid <c>Authorization</c> header.
    /// </summary>
    public static readonly ErrorCategory AuthenticationError = new("AUTHENTICATION_ERROR");

    /// <summary>
    /// The request was invalid. Most commonly, a required parameter was
    /// missing, or a provided parameter had an invalid value.
    /// </summary>
    public static readonly ErrorCategory InvalidRequestError = new("INVALID_REQUEST_ERROR");

    /// <summary>
    /// Your application reached the Connect API rate limit. Retry your
    /// request after a while.
    /// </summary>
    public static readonly ErrorCategory RateLimitError = new("RATE_LIMIT_ERROR");

    /// <summary>
    /// An error occurred while processing a payment method. Most commonly,
    /// the details of the payment method were invalid (such as a card's CVV
    /// or expiration date).
    /// </summary>
    public static readonly ErrorCategory PaymentMethodError = new("PAYMENT_METHOD_ERROR");

    /// <summary>
    /// An error occurred while attempting to process a refund.
    /// </summary>
    public static readonly ErrorCategory RefundError = new("REFUND_ERROR");

    /// <summary>
    /// An error occurred when checking a merchant subscription status
    /// </summary>
    public static readonly ErrorCategory MerchantSubscriptionError = new("MERCHANT_SUBSCRIPTION_ERROR");

    public static ErrorCategory FromValue(string value) => FromValueCore(value);
}
