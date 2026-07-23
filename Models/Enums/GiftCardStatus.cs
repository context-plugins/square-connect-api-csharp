using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the gift card state.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GiftCardStatus>))]
public sealed record GiftCardStatus : StringEnum<GiftCardStatus>
{
    private GiftCardStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The gift card is active and can be used as a payment source.
    /// </summary>
    public static readonly GiftCardStatus Active = new("ACTIVE");

    /// <summary>
    /// Any activity that changes the gift card balance is permanently forbidden.
    /// </summary>
    public static readonly GiftCardStatus Deactivated = new("DEACTIVATED");

    /// <summary>
    /// Any activity that changes the gift card balance is temporarily forbidden.
    /// </summary>
    public static readonly GiftCardStatus Blocked = new("BLOCKED");

    /// <summary>
    /// The gift card is pending activation.
    /// This is the state when a gift card is initially created. You must activate the gift card
    /// before you can use it.
    /// </summary>
    public static readonly GiftCardStatus Pending = new("PENDING");

    public static GiftCardStatus FromValue(string value) => FromValueCore(value);
}
