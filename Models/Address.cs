using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

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
public record Address
{
    /// <summary>
    /// The first line of the address.
    /// <para>
    /// Fields that start with <c>address_line</c> provide the address's most specific
    /// details, like street number, street name, and building name. They do *not*
    /// provide less specific details like city, state/province, or country (these
    /// details are provided in other fields).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line_1")]
    public string? AddressLine1 { get; init; }

    /// <summary>
    /// The second line of the address, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line_2")]
    public string? AddressLine2 { get; init; }

    /// <summary>
    /// The third line of the address, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address_line_3")]
    public string? AddressLine3 { get; init; }

    /// <summary>
    /// A civil entity within the address's country. In the US, this
    /// is the state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrative_district_level_1")]
    public string? AdministrativeDistrictLevel1 { get; init; }

    /// <summary>
    /// A civil entity within the address's <c>administrative_district_level_1</c>.
    /// In the US, this is the county.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrative_district_level_2")]
    public string? AdministrativeDistrictLevel2 { get; init; }

    /// <summary>
    /// A civil entity within the address's <c>administrative_district_level_2</c>,
    /// if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("administrative_district_level_3")]
    public string? AdministrativeDistrictLevel3 { get; init; }

    /// <summary>
    /// The address's country, in ISO 3166-1-alpha-2 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// Optional first name when it's representing recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// Optional last name when it's representing recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The city or town of the address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locality")]
    public string? Locality { get; init; }

    /// <summary>
    /// Optional organization name when it's representing recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("organization")]
    public string? Organization { get; init; }

    /// <summary>
    /// The address's postal code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; init; }

    /// <summary>
    /// A civil region within the address's <c>locality</c>, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sublocality")]
    public string? Sublocality { get; init; }

    /// <summary>
    /// A civil region within the address's <c>sublocality</c>, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sublocality_2")]
    public string? Sublocality2 { get; init; }

    /// <summary>
    /// A civil region within the address's <c>sublocality_2</c>, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sublocality_3")]
    public string? Sublocality3 { get; init; }
}
