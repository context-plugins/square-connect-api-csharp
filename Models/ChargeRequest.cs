using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the parameters that can be included in the body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/charge">Charge</see> endpoint.
/// <para>
/// Deprecated - recommend using <see href="https://developer.squareup.com/reference/square_2021-08-18/payments-api/create-payment">CreatePayment</see>
/// </para>
/// </summary>
public record ChargeRequest
{
    /// <summary>
    /// The basic primitive of multi-party transaction. The value is optional.
    /// The transaction facilitated by you can be split from here.
    /// <para>
    /// If you provide this value, the <c>amount_money</c> value in your additional_recipients
    /// must not be more than 90% of the <c>amount_money</c> value in the charge request.
    /// The <c>location_id</c> must be the valid location of the app owner merchant.
    /// </para>
    /// <para>
    /// This field requires the <c>PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS</c> OAuth permission.
    /// </para>
    /// <para>
    /// This field is currently not supported in sandbox.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additional_recipients")]
    public IReadOnlyList<AdditionalRecipient>? AdditionalRecipients { get; init; }

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
    /// The buyer's email address, if available. This value is optional,
    /// but this transaction is ineligible for chargeback protection if it is not
    /// provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buyer_email_address")]
    public string? BuyerEmailAddress { get; init; }

    /// <summary>
    /// A payment token generated from the <see href="https://developer.squareup.com/reference/sdks/web/payments/objects/Card#Card.tokenize">Card.tokenize()</see> that represents the card
    /// to charge.
    /// <para>
    /// The application that provides a payment token to this endpoint must be the
    /// _same application_ that generated the payment token with the Web Payments SDK.
    /// Otherwise, the nonce is invalid.
    /// </para>
    /// <para>
    /// Do not provide a value for this field if you provide a value for
    /// <c>customer_card_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card_nonce")]
    [MaxLength(192)]
    public string? CardNonce { get; init; }

    /// <summary>
    /// The ID of the customer card on file to charge. Do
    /// not provide a value for this field if you provide a value for <c>card_nonce</c>.
    /// <para>
    /// If you provide this value, you _must_ also provide a value for
    /// <c>customer_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_card_id")]
    [MaxLength(192)]
    public string? CustomerCardId { get; init; }

    /// <summary>
    /// The ID of the customer to associate this transaction with. This field
    /// is required if you provide a value for <c>customer_card_id</c>, and optional
    /// otherwise.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(50)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// If <c>true</c>, the request will only perform an Auth on the provided
    /// card. You can then later perform either a Capture (with the
    /// <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/capture-transaction">CaptureTransaction</see> endpoint) or a Void
    /// (with the <see href="https://developer.squareup.com/reference/square_2021-08-18/transactions-api/void-transaction">VoidTransaction</see> endpoint).
    /// <para>
    /// Default value: <c>false</c>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("delay_capture")]
    public bool? DelayCapture { get; init; }

    /// <summary>
    /// A value you specify that uniquely identifies this
    /// transaction among transactions you've created.
    /// <para>
    /// If you're unsure whether a particular transaction succeeded,
    /// you can reattempt it with the same idempotency key without
    /// worrying about double-charging the buyer.
    /// </para>
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(192, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// An optional note to associate with the transaction.
    /// <para>
    /// This value cannot exceed 60 characters.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    [MaxLength(60)]
    public string? Note { get; init; }

    /// <summary>
    /// The ID of the order to associate with this transaction.
    /// <para>
    /// If you provide this value, the <c>amount_money</c> value of your request must
    /// __exactly match__ the value of the order's <c>total_money</c> field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    [MaxLength(192)]
    public string? OrderId { get; init; }

    /// <summary>
    /// An optional ID you can associate with the transaction for your own
    /// purposes (such as to associate the transaction with an entity ID in your
    /// own database).
    /// <para>
    /// This value cannot exceed 40 characters.
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
    /// A token generated by SqPaymentForm's verifyBuyer() that represents
    /// customer's device info and 3ds challenge result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_token")]
    public string? VerificationToken { get; init; }
}
