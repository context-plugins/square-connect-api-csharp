using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Contains information about the recipient of a fulfillment.
/// </summary>
public record OrderFulfillmentRecipient
{
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
    [JsonPropertyName("address")]
    public Address? Address { get; init; }

    /// <summary>
    /// The customer ID of the customer associated with the fulfillment.
    /// <para>
    /// If <c>customer_id</c> is provided, the fulfillment recipient's <c>display_name</c>,
    /// <c>email_address</c>, and <c>phone_number</c> are automatically populated from the
    /// targeted customer profile. If these fields are set in the request, the request
    /// values overrides the information from the customer profile. If the
    /// targeted customer profile does not contain the necessary information and
    /// these fields are left unset, the request results in an error.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [MaxLength(191)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The display name of the fulfillment recipient.
    /// <para>
    /// If provided, the display name overrides the value pulled from the customer profile indicated by <c>customer_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    [MaxLength(255)]
    public string? DisplayName { get; init; }

    /// <summary>
    /// The email address of the fulfillment recipient.
    /// <para>
    /// If provided, the email address overrides the value pulled from the customer profile indicated by <c>customer_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    [MaxLength(255)]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The phone number of the fulfillment recipient.
    /// <para>
    /// If provided, the phone number overrides the value pulled from the customer profile indicated by <c>customer_id</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    [MaxLength(17)]
    public string? PhoneNumber { get; init; }
}
