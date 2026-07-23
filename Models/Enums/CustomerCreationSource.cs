using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the method used to create the customer profile.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CustomerCreationSource>))]
public sealed record CustomerCreationSource : StringEnum<CustomerCreationSource>
{
    private CustomerCreationSource(string value) : base(value)
    {
    }

    /// <summary>
    /// The default creation source. This source is typically used for backward/future
    /// compatibility when the original source of a customer profile is
    /// unrecognized. For example, when older clients do not support newer
    /// source types.
    /// </summary>
    public static readonly CustomerCreationSource Other = new("OTHER");

    /// <summary>
    /// The customer profile was created automatically when an appointment
    /// was scheduled.
    /// </summary>
    public static readonly CustomerCreationSource Appointments = new("APPOINTMENTS");

    /// <summary>
    /// The customer profile was created automatically when a coupon was issued
    /// using Square Point of Sale.
    /// </summary>
    public static readonly CustomerCreationSource Coupon = new("COUPON");

    /// <summary>
    /// The customer profile was restored through Square's deletion recovery
    /// process.
    /// </summary>
    public static readonly CustomerCreationSource DeletionRecovery = new("DELETION_RECOVERY");

    /// <summary>
    /// The customer profile was created manually through Square Seller Dashboard or the
    /// Point of Sale application.
    /// </summary>
    public static readonly CustomerCreationSource Directory = new("DIRECTORY");

    /// <summary>
    /// The customer profile was created automatically when a gift card was
    /// issued using Square Point of Sale. Customer profiles are created for
    /// both the buyer and the recipient of the gift card.
    /// </summary>
    public static readonly CustomerCreationSource Egifting = new("EGIFTING");

    /// <summary>
    /// The customer profile was created through Square Point of Sale when
    /// signing up for marketing emails during checkout.
    /// </summary>
    public static readonly CustomerCreationSource EmailCollection = new("EMAIL_COLLECTION");

    /// <summary>
    /// The customer profile was created automatically when providing feedback
    /// through a digital receipt.
    /// </summary>
    public static readonly CustomerCreationSource Feedback = new("FEEDBACK");

    /// <summary>
    /// The customer profile was created automatically when importing customer
    /// data through Square Seller Dashboard.
    /// </summary>
    public static readonly CustomerCreationSource Import = new("IMPORT");

    /// <summary>
    /// The customer profile was created automatically during an invoice payment.
    /// </summary>
    public static readonly CustomerCreationSource Invoices = new("INVOICES");

    /// <summary>
    /// The customer profile was created automatically when customers provide a
    /// phone number for loyalty reward programs during checkout.
    /// </summary>
    public static readonly CustomerCreationSource Loyalty = new("LOYALTY");

    /// <summary>
    /// The customer profile was created as the result of a campaign managed
    /// through Square’s Facebook integration.
    /// </summary>
    public static readonly CustomerCreationSource Marketing = new("MARKETING");

    /// <summary>
    /// The customer profile was created as the result of explicitly merging
    /// multiple customer profiles through the Square Seller Dashboard or the Point of
    /// Sale application.
    /// </summary>
    public static readonly CustomerCreationSource Merge = new("MERGE");

    /// <summary>
    /// The customer profile was created through Square's Online Store solution
    /// (legacy service).
    /// </summary>
    public static readonly CustomerCreationSource OnlineStore = new("ONLINE_STORE");

    /// <summary>
    /// The customer profile was created automatically as the result of a successful
    /// transaction that did not explicitly link to an existing customer profile.
    /// </summary>
    public static readonly CustomerCreationSource InstantProfile = new("INSTANT_PROFILE");

    /// <summary>
    /// The customer profile was created through Square's Virtual Terminal.
    /// </summary>
    public static readonly CustomerCreationSource Terminal = new("TERMINAL");

    /// <summary>
    /// The customer profile was created through a Square API call.
    /// </summary>
    public static readonly CustomerCreationSource ThirdParty = new("THIRD_PARTY");

    /// <summary>
    /// The customer profile was created by a third-party product and imported
    /// through an official integration.
    /// </summary>
    public static readonly CustomerCreationSource ThirdPartyImport = new("THIRD_PARTY_IMPORT");

    /// <summary>
    /// The customer profile was restored through Square's unmerge recovery
    /// process.
    /// </summary>
    public static readonly CustomerCreationSource UnmergeRecovery = new("UNMERGE_RECOVERY");

    public static CustomerCreationSource FromValue(string value) => FromValueCore(value);
}
