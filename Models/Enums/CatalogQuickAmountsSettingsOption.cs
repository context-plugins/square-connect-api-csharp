using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Determines a seller's option on Quick Amounts feature.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogQuickAmountsSettingsOption>))]
public sealed record CatalogQuickAmountsSettingsOption : StringEnum<CatalogQuickAmountsSettingsOption>
{
    private CatalogQuickAmountsSettingsOption(string value) : base(value)
    {
    }

    /// <summary>
    /// Option for seller to disable Quick Amounts.
    /// </summary>
    public static readonly CatalogQuickAmountsSettingsOption Disabled = new("DISABLED");

    /// <summary>
    /// Option for seller to choose manually created Quick Amounts.
    /// </summary>
    public static readonly CatalogQuickAmountsSettingsOption Manual = new("MANUAL");

    /// <summary>
    /// Option for seller to choose automatically created Quick Amounts.
    /// </summary>
    public static readonly CatalogQuickAmountsSettingsOption Auto = new("AUTO");

    public static CatalogQuickAmountsSettingsOption FromValue(string value) => FromValueCore(value);
}
