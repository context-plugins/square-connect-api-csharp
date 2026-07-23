using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record Location
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
    /// The email of the location.
    /// This email is visible to the customers of the location.
    /// For example, the email appears on customer receipts.
    /// For example, <c>help&amp;#64;squareup.com</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_email")]
    public string? BusinessEmail { get; init; }

    /// <summary>
    /// Represents the hours of operation for a business location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_hours")]
    public BusinessHours? BusinessHours { get; init; }

    /// <summary>
    /// The business name of the location
    /// This is the name visible to the customers of the location.
    /// For example, this name appears on customer receipts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("business_name")]
    public string? BusinessName { get; init; }

    /// <summary>
    /// The Square features that are enabled for the location.
    /// See <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/LocationCapability">LocationCapability</see> for possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyList<string>? Capabilities { get; init; }

    /// <summary>
    /// Latitude and longitude coordinates.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("coordinates")]
    public Coordinates? Coordinates { get; init; }

    /// <summary>
    /// The country of the location, in ISO 3166-1-alpha-2 format.
    /// <para>
    /// See <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/Country">Country</see> for possible values.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The time when the location was created, in RFC 3339 format.
    /// For more information, see <see href="https://developer.squareup.com/docs/build-basics/working-with-dates">Working with Dates</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The currency used for all transactions at this location,
    /// in ISO 4217 format.
    /// See <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/Currency">Currency</see> for possible values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The description of the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The Facebook profile URL of the location. The URL should begin with 'facebook.com/'. For example, <c>https://www.facebook.com/square</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("facebook_url")]
    public string? FacebookUrl { get; init; }

    /// <summary>
    /// The URL of a full-format logo image for the location. The Seller must choose this logo in the
    /// Seller dashboard (Receipts section) for the logo to appear on transactions (such as receipts, invoices)
    /// that Square generates on behalf of the Seller. This image can have an aspect ratio of 2:1 or greater
    /// and is recommended to be at least 1280x648 pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("full_format_logo_url")]
    public string? FullFormatLogoUrl { get; init; }

    /// <summary>
    /// The Square-issued ID of the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The Instagram username of the location without the '&amp;#64;' symbol. For example, <c>square</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instagram_username")]
    public string? InstagramUsername { get; init; }

    /// <summary>
    /// The language associated with the location, in
    /// <see href="https://tools.ietf.org/html/bcp47#appendix-A">BCP 47 format</see>.
    /// For more information, see <see href="https://developer.squareup.com/docs/locations-api#location-language-code">Location language code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language_code")]
    public string? LanguageCode { get; init; }

    /// <summary>
    /// The URL of the logo image for the location. The Seller must choose this logo in the Seller
    /// dashboard (Receipts section) for the logo to appear on transactions (such as receipts, invoices)
    /// that Square generates on behalf of the Seller. This image should have an aspect ratio
    /// close to 1:1 and is recommended to be at least 200x200 pixels.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo_url")]
    public string? LogoUrl { get; init; }

    /// <summary>
    /// The merchant category code (MCC) of the location, as standardized by ISO 18245.
    /// The MCC describes the kind of goods or services sold at the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }

    /// <summary>
    /// The ID of the merchant that owns the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_id")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The name of the location.
    /// This information appears in the dashboard as the nickname.
    /// A location name must be unique within a seller account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The phone number of the location in human readable format. For example, <c>+353 80 0 098 8099</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The URL of the Point of Sale background image for the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pos_background_url")]
    public string? PosBackgroundUrl { get; init; }

    /// <summary>
    /// The status of the location, either active or inactive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The tax IDs that a Location is operating under.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tax_ids")]
    public TaxIds? TaxIds { get; init; }

    /// <summary>
    /// The <see href="https://www.iana.org/time-zones">IANA Timezone</see> identifier for
    /// the timezone of the location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timezone")]
    public string? Timezone { get; init; }

    /// <summary>
    /// The Twitter username of the location without the '&amp;#64;' symbol. For example, <c>Square</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("twitter_username")]
    public string? TwitterUsername { get; init; }

    /// <summary>
    /// The type of the location, either physical or mobile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The website URL of the location.  For example, <c>https://squareup.com</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("website_url")]
    public string? WebsiteUrl { get; init; }
}
