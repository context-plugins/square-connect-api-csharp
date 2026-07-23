using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The capabilities a location may have.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LocationCapability>))]
public sealed record LocationCapability : StringEnum<LocationCapability>
{
    private LocationCapability(string value) : base(value)
    {
    }

    /// <summary>
    /// The permission to process credit card transactions with Square.
    /// <para>
    /// The location can process credit cards if this value is present
    /// in the <c>capabilities</c> array of the <c>Location</c>.
    /// </para>
    /// </summary>
    public static readonly LocationCapability CreditCardProcessing = new("CREDIT_CARD_PROCESSING");

    /// <summary>
    /// The capability to receive automatic transfers from Square.
    /// <para>
    /// The location can receive automatic transfers of their balance from Square if this value
    /// is present in the <c>capabilities</c> array of the <c>Location</c>.
    /// </para>
    /// </summary>
    public static readonly LocationCapability AutomaticTransfers = new("AUTOMATIC_TRANSFERS");

    public static LocationCapability FromValue(string value) => FromValueCore(value);
}
