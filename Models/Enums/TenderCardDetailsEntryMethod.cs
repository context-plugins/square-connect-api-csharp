using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the method used to enter the card's details.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderCardDetailsEntryMethod>))]
public sealed record TenderCardDetailsEntryMethod : StringEnum<TenderCardDetailsEntryMethod>
{
    private TenderCardDetailsEntryMethod(string value) : base(value)
    {
    }

    /// <summary>
    /// The card was swiped through a Square reader or Square stand.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Swiped = new("SWIPED");

    /// <summary>
    /// The card information was keyed manually into Square Point of Sale or a
    /// Square-hosted web form.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Keyed = new("KEYED");

    /// <summary>
    /// The card was processed via EMV with a Square reader.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Emv = new("EMV");

    /// <summary>
    /// The buyer's card details were already on file with Square.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod OnFile = new("ON_FILE");

    /// <summary>
    /// The card was processed via a contactless (i.e., NFC) transaction
    /// with a Square reader.
    /// </summary>
    public static readonly TenderCardDetailsEntryMethod Contactless = new("CONTACTLESS");

    public static TenderCardDetailsEntryMethod FromValue(string value) => FromValueCore(value);
}
