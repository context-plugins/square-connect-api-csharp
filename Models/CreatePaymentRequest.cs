using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Describes a request to create a payment using
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/create-payment">CreatePayment</see>.
/// </summary>
public record CreatePaymentRequest
{
    /// <summary>
    /// If set to <c>true</c> and charging a Square Gift Card, a payment might be returned with
    /// <c>amount_money</c> equal to less than what was requested. For example, a request for $20 when charging
    /// a Square Gift Card with a balance of $5 results in an APPROVED payment of $5. You might choose
    /// to prompt the buyer for an additional payment to cover the remainder or cancel the Gift Card
    /// payment. This field cannot be <c>true</c> when <c>autocomplete = true</c>.
    /// <para>
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments#partial-payment-gift-card">Partial amount with Square Gift Cards</see>.
    /// </para>
    /// <para>
    /// Default: false
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accept_partial_authorization")]
    public bool? AcceptPartialAuthorization { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("app_fee_money")]
    public Money? AppFeeMoney { get; init; }

    /// <summary>
    /// If set to <c>true</c>, this payment will be completed when possible. If
    /// set to <c>false</c>, this payment is held in an approved state until either
    /// explicitly completed (captured) or canceled (voided). For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments/card-payments#delayed-capture-of-a-card-payment">Delayed capture</see>.
    /// <para>
    /// Default: true
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autocomplete")]
    public bool? Autocomplete { get; init; }

    /// <summary>
    /// Represents a postal address in a country. The address format is based
    /// on an <see href="https://github.com/google/libaddressinput">open-source library from Google</see>. For more information,
    /// see <see href="https://github.com/google/libaddressinput/wiki/AddressValidationMetadata">AddressValidationMetadata</see>.
    /// This format has dedicated fields for four address components: postal code,
    /// locality (city), administrative district (state, prefecture, or province), and
    /// sublocality (town or village). These components have dedicated fields in the
    /// <c>Address</c> object because software sometimes behaves differently based on them.
    /// For example, sales tax software may charge different amounts of sales tax
    /// based on the postal code, and some software is only available in
    /// certain states due to compliance reasons.
    /// <para>
    /// For the remaining address components, the <c>Address</c> type provides the
    /// <c>address_line_1</c> and <c>address_line_2</c> fields for free-form data entry.
    /// These fields are free-form because the remaining address components have
    /// too many variations around the world and typical software does not parse
    /// these components. These fields enable users to enter anything they want.
    /// </para>
    /// <para>
    /// Note that, in the current implementation, all other <c>Address</c> type fields are blank.
    /// These include <c>address_line_3</c>, <c>sublocality_2</c>, <c>sublocality_3</c>,
    /// <c>administrative_district_level_2</c>, <c>administrative_district_level_3</c>,
    /// <c>first_name</c>, <c>last_name</c>, and <c>organization</c>.
    /// </para>
    /// <para>
    /// When it comes to localization, the seller's language preferences
    /// (see <see href="https://developer.squareup.com/docs/locations-api#location-specific-and-seller-level-language-preferences">Language preferences</see>)
    /// are ignored for addresses. Even though Square products (such as Square Point of Sale
    /// and the Seller Dashboard) mostly use a seller's language preference in
    /// communication, when it comes to addresses, they will use English for a US address,
    /// Japanese for an address in Japan, and so on.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_address")]
    public Address? BillingAddress { get; init; }

    /// <summary>
    /// The buyer's email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_email_address")]
    [MaxLength(255)]
    public string? BuyerEmailAddress { get; init; }

    /// <summary>
    /// Stores details about a cash payment. Contains only non-confidential information. For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments/cash-payments">Take Cash Payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_details")]
    public CashPaymentDetails? CashDetails { get; init; }

    /// <summary>
    /// The <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/Customer">Customer</see> ID of the customer associated with the payment.
    /// <para>
    /// This is required if the <c>source_id</c> refers to a card on file created using the Customers API.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The duration of time after the payment's creation when Square automatically cancels the
    /// payment. This automatic cancellation applies only to payments that do not reach a terminal state
    /// (COMPLETED, CANCELED, or FAILED) before the <c>delay_duration</c> time period.
    /// <para>
    /// This parameter should be specified as a time duration, in RFC 3339 format, with a minimum value
    /// of 1 minute.
    /// </para>
    /// <para>
    /// Note: This feature is only supported for card payments. This parameter can only be set for a delayed
    /// capture payment (<c>autocomplete=false</c>).
    /// </para>
    /// <para>
    /// Default:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Card-present payments: "PT36H" (36 hours) from the creation time.</description></item>
    ///   <item><description>Card-not-present payments: "P7D" (7 days) from the creation time.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_duration")]
    public string? DelayDuration { get; init; }

    /// <summary>
    /// Stores details about an external payment. Contains only non-confidential information.
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments/external-payments">Take External Payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_details")]
    public ExternalPaymentDetails? ExternalDetails { get; init; }

    /// <summary>
    /// A unique string that identifies this <c>CreatePayment</c> request. Keys can be any valid string
    /// but must be unique for every <c>CreatePayment</c> request.
    /// <para>
    /// Max: 45 characters
    /// </para>
    /// <para>
    /// Note: The number of allowed characters might be less than the stated maximum, if multi-byte
    /// characters are used.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(45, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// The location ID to associate with the payment. If not specified, the default location is
    /// used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// An optional note to be entered by the developer when creating a payment.
    /// <para>
    /// Limit 500 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(500)]
    public string? Note { get; init; }

    /// <summary>
    /// Associates a previously created order with this payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public string? OrderId { get; init; }

    /// <summary>
    /// A user-defined ID to associate with the payment.
    /// <para>
    /// You can use this field to associate the payment to an entity in an external system
    /// (for example, you might specify an order ID that is generated by a third-party shopping cart).
    /// </para>
    /// <para>
    /// Limit 40 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    [MaxLength(40)]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// Represents a postal address in a country. The address format is based
    /// on an <see href="https://github.com/google/libaddressinput">open-source library from Google</see>. For more information,
    /// see <see href="https://github.com/google/libaddressinput/wiki/AddressValidationMetadata">AddressValidationMetadata</see>.
    /// This format has dedicated fields for four address components: postal code,
    /// locality (city), administrative district (state, prefecture, or province), and
    /// sublocality (town or village). These components have dedicated fields in the
    /// <c>Address</c> object because software sometimes behaves differently based on them.
    /// For example, sales tax software may charge different amounts of sales tax
    /// based on the postal code, and some software is only available in
    /// certain states due to compliance reasons.
    /// <para>
    /// For the remaining address components, the <c>Address</c> type provides the
    /// <c>address_line_1</c> and <c>address_line_2</c> fields for free-form data entry.
    /// These fields are free-form because the remaining address components have
    /// too many variations around the world and typical software does not parse
    /// these components. These fields enable users to enter anything they want.
    /// </para>
    /// <para>
    /// Note that, in the current implementation, all other <c>Address</c> type fields are blank.
    /// These include <c>address_line_3</c>, <c>sublocality_2</c>, <c>sublocality_3</c>,
    /// <c>administrative_district_level_2</c>, <c>administrative_district_level_3</c>,
    /// <c>first_name</c>, <c>last_name</c>, and <c>organization</c>.
    /// </para>
    /// <para>
    /// When it comes to localization, the seller's language preferences
    /// (see <see href="https://developer.squareup.com/docs/locations-api#location-specific-and-seller-level-language-preferences">Language preferences</see>)
    /// are ignored for addresses. Even though Square products (such as Square Point of Sale
    /// and the Seller Dashboard) mostly use a seller's language preference in
    /// communication, when it comes to addresses, they will use English for a US address,
    /// Japanese for an address in Japan, and so on.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shipping_address")]
    public Address? ShippingAddress { get; init; }

    /// <summary>
    /// The ID for the source of funds for this payment. This can be a payment token
    /// (card nonce) generated by the Square payment form or a card on file made with the
    /// Customers API. If recording a payment that the seller
    /// received outside of Square, specify either "CASH" or "EXTERNAL".
    /// For more information, see
    /// <see href="https://developer.squareup.com/docs/payments-api/take-payments">Take Payments</see>.
    /// </summary>
    [JsonPropertyName("source_id")]
    [MinLength(1)]
    public required string SourceId { get; init; }

    /// <summary>
    /// Optional additional payment information to include on the customer's card statement
    /// as part of the statement description. This can be, for example, an invoice number, ticket number,
    /// or short description that uniquely identifies the purchase.
    /// <para>
    /// Note that the <c>statement_description_identifier</c> might get truncated on the statement description
    /// to fit the required information including the Square identifier (SQ *) and name of the
    /// seller taking the payment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statement_description_identifier")]
    [MaxLength(20)]
    public string? StatementDescriptionIdentifier { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip_money")]
    public Money? TipMoney { get; init; }

    /// <summary>
    /// An identifying token generated by <see href="https://developer.squareup.com/reference/sdks/web/payments/objects/Payments#Payments.verifyBuyer">payments.verifyBuyer()</see>.
    /// Verification tokens encapsulate customer device information and 3-D Secure
    /// challenge results to indicate that Square has verified the buyer identity.
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/sca-overview">SCA Overview</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_token")]
    public string? VerificationToken { get; init; }
}
