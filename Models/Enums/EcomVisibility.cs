using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Determines item visibility in Ecom (Online Store) and Online Checkout.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EcomVisibility>))]
public sealed record EcomVisibility : StringEnum<EcomVisibility>
{
    private EcomVisibility(string value) : base(value)
    {
    }

    /// <summary>
    /// Item is not synced with Ecom (Weebly). This is the default state
    /// </summary>
    public static readonly EcomVisibility Unindexed = new("UNINDEXED");

    /// <summary>
    /// Item is synced but is unavailable within Ecom (Weebly) and Online Checkout
    /// </summary>
    public static readonly EcomVisibility Unavailable = new("UNAVAILABLE");

    /// <summary>
    /// Option for seller to choose manually created Quick Amounts.
    /// </summary>
    public static readonly EcomVisibility Hidden = new("HIDDEN");

    /// <summary>
    /// Item is synced but available within Ecom (Weebly) and Online Checkout but is hidden from Ecom Store.
    /// </summary>
    public static readonly EcomVisibility Visible = new("VISIBLE");

    public static EcomVisibility FromValue(string value) => FromValueCore(value);
}
