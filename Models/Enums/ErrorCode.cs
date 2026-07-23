using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the specific error that occurred during a request to a
/// Square API.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorCode>))]
public sealed record ErrorCode : StringEnum<ErrorCode>
{
    private ErrorCode(string value) : base(value)
    {
    }

    /// <summary>
    /// A general server error occurred.
    /// </summary>
    public static readonly ErrorCode InternalServerError = new("INTERNAL_SERVER_ERROR");

    /// <summary>
    /// A general authorization error occurred.
    /// </summary>
    public static readonly ErrorCode Unauthorized = new("UNAUTHORIZED");

    /// <summary>
    /// The provided access token has expired.
    /// </summary>
    public static readonly ErrorCode AccessTokenExpired = new("ACCESS_TOKEN_EXPIRED");

    /// <summary>
    /// The provided access token has been revoked.
    /// </summary>
    public static readonly ErrorCode AccessTokenRevoked = new("ACCESS_TOKEN_REVOKED");

    /// <summary>
    /// The provided client has been disabled.
    /// </summary>
    public static readonly ErrorCode ClientDisabled = new("CLIENT_DISABLED");

    /// <summary>
    /// A general access error occurred.
    /// </summary>
    public static readonly ErrorCode Forbidden = new("FORBIDDEN");

    /// <summary>
    /// The provided access token does not have permission
    /// to execute the requested action.
    /// </summary>
    public static readonly ErrorCode InsufficientScopes = new("INSUFFICIENT_SCOPES");

    /// <summary>
    /// The calling application was disabled.
    /// </summary>
    public static readonly ErrorCode ApplicationDisabled = new("APPLICATION_DISABLED");

    /// <summary>
    /// The calling application was created prior to
    /// 2016-03-30 and is not compatible with v2 Square API calls.
    /// </summary>
    public static readonly ErrorCode V1Application = new("V1_APPLICATION");

    /// <summary>
    /// The calling application is using an access token
    /// created prior to 2016-03-30 and is not compatible with v2 Square API
    /// calls.
    /// </summary>
    public static readonly ErrorCode V1AccessToken = new("V1_ACCESS_TOKEN");

    /// <summary>
    /// The location provided in the API call is not
    /// enabled for credit card processing.
    /// </summary>
    public static readonly ErrorCode CardProcessingNotEnabled = new("CARD_PROCESSING_NOT_ENABLED");

    /// <summary>
    /// A required subscription was not found for the merchant
    /// </summary>
    public static readonly ErrorCode MerchantSubscriptionNotFound = new("MERCHANT_SUBSCRIPTION_NOT_FOUND");

    /// <summary>
    /// A general error occurred with the request.
    /// </summary>
    public static readonly ErrorCode BadRequest = new("BAD_REQUEST");

    /// <summary>
    /// The request is missing a required path, query, or
    /// body parameter.
    /// </summary>
    public static readonly ErrorCode MissingRequiredParameter = new("MISSING_REQUIRED_PARAMETER");

    /// <summary>
    /// The value provided in the request is the wrong
    /// type. For example, a string instead of an integer.
    /// </summary>
    public static readonly ErrorCode IncorrectType = new("INCORRECT_TYPE");

    /// <summary>
    /// Formatting for the provided time value is
    /// incorrect.
    /// </summary>
    public static readonly ErrorCode InvalidTime = new("INVALID_TIME");

    /// <summary>
    /// The time range provided in the request is invalid.
    /// For example, the end time is before the start time.
    /// </summary>
    public static readonly ErrorCode InvalidTimeRange = new("INVALID_TIME_RANGE");

    /// <summary>
    /// The provided value is invalid. For example,
    /// including <c>%</c> in a phone number.
    /// </summary>
    public static readonly ErrorCode InvalidValue = new("INVALID_VALUE");

    /// <summary>
    /// The pagination cursor included in the request is
    /// invalid.
    /// </summary>
    public static readonly ErrorCode InvalidCursor = new("INVALID_CURSOR");

    /// <summary>
    /// The query parameters provided is invalid for the
    /// requested endpoint.
    /// </summary>
    public static readonly ErrorCode UnknownQueryParameter = new("UNKNOWN_QUERY_PARAMETER");

    /// <summary>
    /// One or more of the request parameters conflict with
    /// each other.
    /// </summary>
    public static readonly ErrorCode ConflictingParameters = new("CONFLICTING_PARAMETERS");

    /// <summary>
    /// The request body is not a JSON object.
    /// </summary>
    public static readonly ErrorCode ExpectedJsonBody = new("EXPECTED_JSON_BODY");

    /// <summary>
    /// The provided sort order is not a valid key.
    /// Currently, sort order must be <c>ASC</c> or <c>DESC</c>.
    /// </summary>
    public static readonly ErrorCode InvalidSortOrder = new("INVALID_SORT_ORDER");

    /// <summary>
    /// The provided value does not match an expected
    /// regular expression.
    /// </summary>
    public static readonly ErrorCode ValueRegexMismatch = new("VALUE_REGEX_MISMATCH");

    /// <summary>
    /// The provided string value is shorter than the
    /// minimum length allowed.
    /// </summary>
    public static readonly ErrorCode ValueTooShort = new("VALUE_TOO_SHORT");

    /// <summary>
    /// The provided string value is longer than the
    /// maximum length allowed.
    /// </summary>
    public static readonly ErrorCode ValueTooLong = new("VALUE_TOO_LONG");

    /// <summary>
    /// The provided value is less than the supported
    /// minimum.
    /// </summary>
    public static readonly ErrorCode ValueTooLow = new("VALUE_TOO_LOW");

    /// <summary>
    /// The provided value is greater than the supported
    /// maximum.
    /// </summary>
    public static readonly ErrorCode ValueTooHigh = new("VALUE_TOO_HIGH");

    /// <summary>
    /// The provided value has a default (empty) value
    /// such as a blank string.
    /// </summary>
    public static readonly ErrorCode ValueEmpty = new("VALUE_EMPTY");

    /// <summary>
    /// The provided array has too many elements.
    /// </summary>
    public static readonly ErrorCode ArrayLengthTooLong = new("ARRAY_LENGTH_TOO_LONG");

    /// <summary>
    /// The provided array has too few elements.
    /// </summary>
    public static readonly ErrorCode ArrayLengthTooShort = new("ARRAY_LENGTH_TOO_SHORT");

    /// <summary>
    /// The provided array is empty.
    /// </summary>
    public static readonly ErrorCode ArrayEmpty = new("ARRAY_EMPTY");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// boolean.
    /// </summary>
    public static readonly ErrorCode ExpectedBoolean = new("EXPECTED_BOOLEAN");

    /// <summary>
    /// The endpoint expected the provided value to be an
    /// integer.
    /// </summary>
    public static readonly ErrorCode ExpectedInteger = new("EXPECTED_INTEGER");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// float.
    /// </summary>
    public static readonly ErrorCode ExpectedFloat = new("EXPECTED_FLOAT");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// string.
    /// </summary>
    public static readonly ErrorCode ExpectedString = new("EXPECTED_STRING");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// JSON object.
    /// </summary>
    public static readonly ErrorCode ExpectedObject = new("EXPECTED_OBJECT");

    /// <summary>
    /// The endpoint expected the provided value to be an
    /// array or list.
    /// </summary>
    public static readonly ErrorCode ExpectedArray = new("EXPECTED_ARRAY");

    /// <summary>
    /// The endpoint expected the provided value to be a
    /// map or associative array.
    /// </summary>
    public static readonly ErrorCode ExpectedMap = new("EXPECTED_MAP");

    /// <summary>
    /// The endpoint expected the provided value to be an
    /// array encoded in base64.
    /// </summary>
    public static readonly ErrorCode ExpectedBase64EncodedByteArray = new("EXPECTED_BASE64_ENCODED_BYTE_ARRAY");

    /// <summary>
    /// One or more objects in the array does not match the
    /// array type.
    /// </summary>
    public static readonly ErrorCode InvalidArrayValue = new("INVALID_ARRAY_VALUE");

    /// <summary>
    /// The provided static string is not valid for the
    /// field.
    /// </summary>
    public static readonly ErrorCode InvalidEnumValue = new("INVALID_ENUM_VALUE");

    /// <summary>
    /// Invalid content type header.
    /// </summary>
    public static readonly ErrorCode InvalidContentType = new("INVALID_CONTENT_TYPE");

    /// <summary>
    /// Only relevant for applications created prior to
    /// 2016-03-30. Indicates there was an error while parsing form values.
    /// </summary>
    public static readonly ErrorCode InvalidFormValue = new("INVALID_FORM_VALUE");

    /// <summary>
    /// The provided customer id can't be found in the merchant's customers list.
    /// </summary>
    public static readonly ErrorCode CustomerNotFound = new("CUSTOMER_NOT_FOUND");

    /// <summary>
    /// A general error occurred.
    /// </summary>
    public static readonly ErrorCode OneInstrumentExpected = new("ONE_INSTRUMENT_EXPECTED");

    /// <summary>
    /// A general error occurred.
    /// </summary>
    public static readonly ErrorCode NoFieldsSet = new("NO_FIELDS_SET");

    /// <summary>
    /// Too many entries in the map field.
    /// </summary>
    public static readonly ErrorCode TooManyMapEntries = new("TOO_MANY_MAP_ENTRIES");

    /// <summary>
    /// The length of one of the provided keys in the map is too short.
    /// </summary>
    public static readonly ErrorCode MapKeyLengthTooShort = new("MAP_KEY_LENGTH_TOO_SHORT");

    /// <summary>
    /// The length of one of the provided keys in the map is too long.
    /// </summary>
    public static readonly ErrorCode MapKeyLengthTooLong = new("MAP_KEY_LENGTH_TOO_LONG");

    /// <summary>
    /// The card issuer declined the request because the card is expired.
    /// </summary>
    public static readonly ErrorCode CardExpired = new("CARD_EXPIRED");

    /// <summary>
    /// The expiration date for the payment card is invalid. For example,
    /// it indicates a date in the past.
    /// </summary>
    public static readonly ErrorCode InvalidExpiration = new("INVALID_EXPIRATION");

    /// <summary>
    /// The expiration year for the payment card is invalid. For example,
    /// it indicates a year in the past or contains invalid characters.
    /// </summary>
    public static readonly ErrorCode InvalidExpirationYear = new("INVALID_EXPIRATION_YEAR");

    /// <summary>
    /// The expiration date for the payment card is invalid. For example,
    /// it contains invalid characters.
    /// </summary>
    public static readonly ErrorCode InvalidExpirationDate = new("INVALID_EXPIRATION_DATE");

    /// <summary>
    /// The credit card provided is not from a supported issuer.
    /// </summary>
    public static readonly ErrorCode UnsupportedCardBrand = new("UNSUPPORTED_CARD_BRAND");

    /// <summary>
    /// The entry method for the credit card (swipe, dip, tap) is not supported.
    /// </summary>
    public static readonly ErrorCode UnsupportedEntryMethod = new("UNSUPPORTED_ENTRY_METHOD");

    /// <summary>
    /// The encrypted card information is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidEncryptedCard = new("INVALID_ENCRYPTED_CARD");

    /// <summary>
    /// The credit card cannot be validated based on the provided details.
    /// </summary>
    public static readonly ErrorCode InvalidCard = new("INVALID_CARD");

    /// <summary>
    /// Square received a decline without any additional information.
    /// If the payment information seems correct, the buyer can contact their
    /// issuer to ask for more information.
    /// </summary>
    public static readonly ErrorCode GenericDecline = new("GENERIC_DECLINE");

    /// <summary>
    /// The card issuer declined the request because the CVV value is invalid.
    /// </summary>
    public static readonly ErrorCode CvvFailure = new("CVV_FAILURE");

    /// <summary>
    /// The card issuer declined the request because the postal code is invalid.
    /// </summary>
    public static readonly ErrorCode AddressVerificationFailure = new("ADDRESS_VERIFICATION_FAILURE");

    /// <summary>
    /// The issuer was not able to locate the account on record.
    /// </summary>
    public static readonly ErrorCode InvalidAccount = new("INVALID_ACCOUNT");

    /// <summary>
    /// The currency associated with the payment is not valid for the provided
    /// funding source. For example, a gift card funded in USD cannot be used to process
    /// payments in GBP.
    /// </summary>
    public static readonly ErrorCode CurrencyMismatch = new("CURRENCY_MISMATCH");

    /// <summary>
    /// The funding source has insufficient funds to cover the payment.
    /// </summary>
    public static readonly ErrorCode InsufficientFunds = new("INSUFFICIENT_FUNDS");

    /// <summary>
    /// The Square account does not have the permissions to accept
    /// this payment. For example, Square may limit which merchants are
    /// allowed to receive gift card payments.
    /// </summary>
    public static readonly ErrorCode InsufficientPermissions = new("INSUFFICIENT_PERMISSIONS");

    /// <summary>
    /// The card issuer has declined the transaction due to restrictions on where the card can be used.
    /// For example, a gift card is limited to a single merchant.
    /// </summary>
    public static readonly ErrorCode CardholderInsufficientPermissions = new("CARDHOLDER_INSUFFICIENT_PERMISSIONS");

    /// <summary>
    /// The Square account cannot take payments in the specified region.
    /// A Square account can take payments only from the region where the account was created.
    /// </summary>
    public static readonly ErrorCode InvalidLocation = new("INVALID_LOCATION");

    /// <summary>
    /// The card issuer has determined the payment amount is either too high or too low.
    /// The API returns the error code mostly for credit cards (for example, the card reached
    /// the credit limit). However, sometimes the issuer bank can indicate the error for debit
    /// or prepaid cards (for example, card has insufficient funds).
    /// </summary>
    public static readonly ErrorCode TransactionLimit = new("TRANSACTION_LIMIT");

    /// <summary>
    /// The card issuer declined the request because the issuer requires voice authorization from the cardholder.
    /// </summary>
    public static readonly ErrorCode VoiceFailure = new("VOICE_FAILURE");

    /// <summary>
    /// The specified card number is invalid. For example, it is of
    /// incorrect length or is incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode PanFailure = new("PAN_FAILURE");

    /// <summary>
    /// The card expiration date is either invalid or indicates that the
    /// card is expired.
    /// </summary>
    public static readonly ErrorCode ExpirationFailure = new("EXPIRATION_FAILURE");

    /// <summary>
    /// The card is not supported either in the geographic region or by
    /// the <see href="https://developer.squareup.com/docs/locations-api#initialize-a-merchant-category-code">merchant category code</see> (MCC).
    /// </summary>
    public static readonly ErrorCode CardNotSupported = new("CARD_NOT_SUPPORTED");

    /// <summary>
    /// The card issuer declined the request because the PIN is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidPin = new("INVALID_PIN");

    /// <summary>
    /// The payment is missing a required PIN.
    /// </summary>
    public static readonly ErrorCode MissingPin = new("MISSING_PIN");

    /// <summary>
    /// The payment is missing a required ACCOUNT_TYPE parameter.
    /// </summary>
    public static readonly ErrorCode MissingAccountType = new("MISSING_ACCOUNT_TYPE");

    /// <summary>
    /// The postal code is incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode InvalidPostalCode = new("INVALID_POSTAL_CODE");

    /// <summary>
    /// The app_fee_money on a payment is too high.
    /// </summary>
    public static readonly ErrorCode InvalidFees = new("INVALID_FEES");

    /// <summary>
    /// The card must be swiped, tapped, or dipped. Payments attempted by manually entering the card number are declined.
    /// </summary>
    public static readonly ErrorCode ManuallyEnteredPaymentNotSupported = new("MANUALLY_ENTERED_PAYMENT_NOT_SUPPORTED");

    /// <summary>
    /// Square declined the request because the payment amount exceeded the processing limit for this merchant.
    /// </summary>
    public static readonly ErrorCode PaymentLimitExceeded = new("PAYMENT_LIMIT_EXCEEDED");

    /// <summary>
    /// When a Gift Card is a payment source, you can allow taking a partial payment
    /// by adding the <c>accept_partial_authorization</c> parameter in the request.
    /// However, taking such a partial payment does not work if your request also includes
    /// <c>tip_money</c>, <c>app_fee_money</c>, or both. Square declines such payments and returns
    /// the <c>GIFT_CARD_AVAILABLE_AMOUNT</c> error.
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/error-codes#createpayment-errors-additional-information">CreatePayment errors (additional information)</see>.
    /// </summary>
    public static readonly ErrorCode GiftCardAvailableAmount = new("GIFT_CARD_AVAILABLE_AMOUNT");

    /// <summary>
    /// The account provided cannot carry out transactions.
    /// </summary>
    public static readonly ErrorCode AccountUnusable = new("ACCOUNT_UNUSABLE");

    /// <summary>
    /// Bank account rejected or was not authorized for the payment.
    /// </summary>
    public static readonly ErrorCode BuyerRefusedPayment = new("BUYER_REFUSED_PAYMENT");

    /// <summary>
    /// The application tried to update a delayed-capture payment that has expired.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionExpired = new("DELAYED_TRANSACTION_EXPIRED");

    /// <summary>
    /// The application tried to cancel a delayed-capture payment that was already cancelled.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionCanceled = new("DELAYED_TRANSACTION_CANCELED");

    /// <summary>
    /// The application tried to capture a delayed-capture payment that was already captured.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionCaptured = new("DELAYED_TRANSACTION_CAPTURED");

    /// <summary>
    /// The application tried to update a delayed-capture payment that failed.
    /// </summary>
    public static readonly ErrorCode DelayedTransactionFailed = new("DELAYED_TRANSACTION_FAILED");

    /// <summary>
    /// The provided card token (nonce) has expired.
    /// </summary>
    public static readonly ErrorCode CardTokenExpired = new("CARD_TOKEN_EXPIRED");

    /// <summary>
    /// The provided card token (nonce) was already used to process payment.
    /// </summary>
    public static readonly ErrorCode CardTokenUsed = new("CARD_TOKEN_USED");

    /// <summary>
    /// The requested payment amount is too high for the provided payment source.
    /// </summary>
    public static readonly ErrorCode AmountTooHigh = new("AMOUNT_TOO_HIGH");

    /// <summary>
    /// The API request references an unsupported instrument type/
    /// </summary>
    public static readonly ErrorCode UnsupportedInstrumentType = new("UNSUPPORTED_INSTRUMENT_TYPE");

    /// <summary>
    /// The requested refund amount exceeds the amount available to refund.
    /// </summary>
    public static readonly ErrorCode RefundAmountInvalid = new("REFUND_AMOUNT_INVALID");

    /// <summary>
    /// The payment already has a pending refund.
    /// </summary>
    public static readonly ErrorCode RefundAlreadyPending = new("REFUND_ALREADY_PENDING");

    /// <summary>
    /// The payment is not refundable. For example, a previous refund has
    /// already been rejected and no new refunds can be accepted.
    /// </summary>
    public static readonly ErrorCode PaymentNotRefundable = new("PAYMENT_NOT_REFUNDABLE");

    /// <summary>
    /// Request failed - The card issuer declined the refund.
    /// </summary>
    public static readonly ErrorCode RefundDeclined = new("REFUND_DECLINED");

    /// <summary>
    /// Generic error - the provided card data is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidCardData = new("INVALID_CARD_DATA");

    /// <summary>
    /// The provided source id was already used to create a card.
    /// </summary>
    public static readonly ErrorCode SourceUsed = new("SOURCE_USED");

    /// <summary>
    /// The provided source id has expired.
    /// </summary>
    public static readonly ErrorCode SourceExpired = new("SOURCE_EXPIRED");

    /// <summary>
    /// The referenced loyalty program reward tier is not supported.
    /// This could happen if the reward tier created in a first party
    /// application is incompatible with the Loyalty API.
    /// </summary>
    public static readonly ErrorCode UnsupportedLoyaltyRewardTier = new("UNSUPPORTED_LOYALTY_REWARD_TIER");

    /// <summary>
    /// Generic error - the given location does not matching what is expected.
    /// </summary>
    public static readonly ErrorCode LocationMismatch = new("LOCATION_MISMATCH");

    /// <summary>
    /// The provided idempotency key has already been used.
    /// </summary>
    public static readonly ErrorCode IdempotencyKeyReused = new("IDEMPOTENCY_KEY_REUSED");

    /// <summary>
    /// General error - the value provided was unexpected.
    /// </summary>
    public static readonly ErrorCode UnexpectedValue = new("UNEXPECTED_VALUE");

    /// <summary>
    /// The API request is not supported in sandbox.
    /// </summary>
    public static readonly ErrorCode SandboxNotSupported = new("SANDBOX_NOT_SUPPORTED");

    /// <summary>
    /// The provided email address is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidEmailAddress = new("INVALID_EMAIL_ADDRESS");

    /// <summary>
    /// The provided phone number is invalid.
    /// </summary>
    public static readonly ErrorCode InvalidPhoneNumber = new("INVALID_PHONE_NUMBER");

    /// <summary>
    /// The provided checkout URL has expired.
    /// </summary>
    public static readonly ErrorCode CheckoutExpired = new("CHECKOUT_EXPIRED");

    /// <summary>
    /// Bad certificate.
    /// </summary>
    public static readonly ErrorCode BadCertificate = new("BAD_CERTIFICATE");

    /// <summary>
    /// The provided Square-Version is incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode InvalidSquareVersionFormat = new("INVALID_SQUARE_VERSION_FORMAT");

    /// <summary>
    /// The provided Square-Version is incompatible with the requested action.
    /// </summary>
    public static readonly ErrorCode ApiVersionIncompatible = new("API_VERSION_INCOMPATIBLE");

    /// <summary>
    /// The card was declined.
    /// </summary>
    public static readonly ErrorCode CardDeclined = new("CARD_DECLINED");

    /// <summary>
    /// The CVV could not be verified.
    /// </summary>
    public static readonly ErrorCode VerifyCvvFailure = new("VERIFY_CVV_FAILURE");

    /// <summary>
    /// The AVS could not be verified.
    /// </summary>
    public static readonly ErrorCode VerifyAvsFailure = new("VERIFY_AVS_FAILURE");

    /// <summary>
    /// The payment card was declined with a request
    /// for the card holder to call the issuer.
    /// </summary>
    public static readonly ErrorCode CardDeclinedCallIssuer = new("CARD_DECLINED_CALL_ISSUER");

    /// <summary>
    /// The payment card was declined with a request
    /// for additional verification.
    /// </summary>
    public static readonly ErrorCode CardDeclinedVerificationRequired = new("CARD_DECLINED_VERIFICATION_REQUIRED");

    /// <summary>
    /// The card expiration date is either missing or
    /// incorrectly formatted.
    /// </summary>
    public static readonly ErrorCode BadExpiration = new("BAD_EXPIRATION");

    /// <summary>
    /// The card issuer requires that the card be read
    /// using a chip reader.
    /// </summary>
    public static readonly ErrorCode ChipInsertionRequired = new("CHIP_INSERTION_REQUIRED");

    /// <summary>
    /// The card has exhausted its available pin entry
    /// retries set by the card issuer. Resolving the error typically requires the
    /// card holder to contact the card issuer.
    /// </summary>
    public static readonly ErrorCode AllowablePinTriesExceeded = new("ALLOWABLE_PIN_TRIES_EXCEEDED");

    /// <summary>
    /// The card issuer declined the refund.
    /// </summary>
    public static readonly ErrorCode ReservationDeclined = new("RESERVATION_DECLINED");

    /// <summary>
    /// Not Found - a general error occurred.
    /// </summary>
    public static readonly ErrorCode NotFound = new("NOT_FOUND");

    /// <summary>
    /// Square could not find the associated Apple Pay certificate.
    /// </summary>
    public static readonly ErrorCode ApplePaymentProcessingCertificateHashNotFound = new("APPLE_PAYMENT_PROCESSING_CERTIFICATE_HASH_NOT_FOUND");

    /// <summary>
    /// Method Not Allowed - a general error occurred.
    /// </summary>
    public static readonly ErrorCode MethodNotAllowed = new("METHOD_NOT_ALLOWED");

    /// <summary>
    /// Not Acceptable - a general error occurred.
    /// </summary>
    public static readonly ErrorCode NotAcceptable = new("NOT_ACCEPTABLE");

    /// <summary>
    /// Request Timeout - a general error occurred.
    /// </summary>
    public static readonly ErrorCode RequestTimeout = new("REQUEST_TIMEOUT");

    /// <summary>
    /// Conflict - a general error occurred.
    /// </summary>
    public static readonly ErrorCode Conflict = new("CONFLICT");

    /// <summary>
    /// The target resource is no longer available and this
    /// condition is likely to be permanent.
    /// </summary>
    public static readonly ErrorCode Gone = new("GONE");

    /// <summary>
    /// Request Entity Too Large - a general error occurred.
    /// </summary>
    public static readonly ErrorCode RequestEntityTooLarge = new("REQUEST_ENTITY_TOO_LARGE");

    /// <summary>
    /// Unsupported Media Type - a general error occurred.
    /// </summary>
    public static readonly ErrorCode UnsupportedMediaType = new("UNSUPPORTED_MEDIA_TYPE");

    /// <summary>
    /// Unprocessable Entity - a general error occurred.
    /// </summary>
    public static readonly ErrorCode UnprocessableEntity = new("UNPROCESSABLE_ENTITY");

    /// <summary>
    /// Rate Limited - a general error occurred.
    /// </summary>
    public static readonly ErrorCode RateLimited = new("RATE_LIMITED");

    /// <summary>
    /// Not Implemented - a general error occurred.
    /// </summary>
    public static readonly ErrorCode NotImplemented = new("NOT_IMPLEMENTED");

    /// <summary>
    /// Bad Gateway - a general error occurred.
    /// </summary>
    public static readonly ErrorCode BadGateway = new("BAD_GATEWAY");

    /// <summary>
    /// Service Unavailable - a general error occurred.
    /// </summary>
    public static readonly ErrorCode ServiceUnavailable = new("SERVICE_UNAVAILABLE");

    /// <summary>
    /// A temporary internal error occurred. You can safely retry your call
    /// using the same idempotency key.
    /// </summary>
    public static readonly ErrorCode TemporaryError = new("TEMPORARY_ERROR");

    /// <summary>
    /// Gateway Timeout - a general error occurred.
    /// </summary>
    public static readonly ErrorCode GatewayTimeout = new("GATEWAY_TIMEOUT");

    public static ErrorCode FromValue(string value) => FromValueCore(value);
}
