using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a Square customer profile in the Customer Directory of a Square seller.
/// </summary>
public record Customer
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
    /// The birthday associated with the customer profile, in RFC 3339 format. The year is optional. The timezone and time are not allowed.
    /// For example, <c>0000-09-21T00:00:00-00:00</c> represents a birthday on September 21 and <c>1998-09-21T00:00:00-00:00</c> represents a birthday on September 21, 1998.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("birthday")]
    public string? Birthday { get; init; }

    /// <summary>
    /// Payment details of the credit, debit, and gift cards stored on file for the customer profile.
    /// <para>
    /// DEPRECATED at version 2021-06-16. Replaced by calling <see href="https://developer.squareup.com/reference/square_2021-08-18/cards-api/list-cards">ListCards</see> (for credit and debit cards on file)
    /// or <see href="https://developer.squareup.com/reference/square_2021-08-18/gift-cards-api/list-gift-cards">ListGiftCards</see> (for gift cards on file) and including the <c>customer_id</c> query parameter.
    /// For more information, see <see href="https://developer.squareup.com/docs/customers-api/use-the-api/integrate-with-other-services#migrate-customer-cards">Migrate to the Cards API and Gift Cards API</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cards")]
    public IReadOnlyList<Card>? Cards { get; init; }

    /// <summary>
    /// A business name associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("company_name")]
    public string? CompanyName { get; init; }

    /// <summary>
    /// The timestamp when the customer profile was created, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// A creation source represents the method used to create the
    /// customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creation_source")]
    public string? CreationSource { get; init; }

    /// <summary>
    /// The email address associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The family (i.e., last) name associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// The given (i.e., first) name associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The IDs of customer groups the customer belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group_ids")]
    public IReadOnlyList<string>? GroupIds { get; init; }

    /// <summary>
    /// A unique Square-assigned ID for the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// A nickname for the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nickname")]
    public string? Nickname { get; init; }

    /// <summary>
    /// A custom note associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("note")]
    public string? Note { get; init; }

    /// <summary>
    /// The 11-digit phone number associated with the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// Represents communication preferences for the customer profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("preferences")]
    public CustomerPreferences? Preferences { get; init; }

    /// <summary>
    /// An optional second ID used to associate the customer profile with an
    /// entity in another system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// The IDs of segments the customer belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segment_ids")]
    public IReadOnlyList<string>? SegmentIds { get; init; }

    /// <summary>
    /// The timestamp when the customer profile was last updated, in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// The Square-assigned version number of the customer profile. The version number is incremented each time an update is committed to the customer profile, except for changes to customer segment membership and cards on file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public long? Version { get; init; }
}
