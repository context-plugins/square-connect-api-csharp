using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Provides customer data that Square uses to deliver an invoice.
/// </summary>
public record InvoiceRecipient
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
    /// The name of the recipient's company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; init; }

    /// <summary>
    /// The ID of the customer. This is the customer profile ID that
    /// you provide when creating a draft invoice.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_id")]
    [StringLength(255, MinimumLength = 1)]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The recipient's email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The recipient's family (that is, last) name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// The recipient's given (that is, first) name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The recipient's phone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }
}
