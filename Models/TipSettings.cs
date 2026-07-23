using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record TipSettings
{
    /// <summary>
    /// Indicates whether tipping is enabled for this checkout. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_tipping")]
    public bool? AllowTipping { get; init; }

    /// <summary>
    /// Indicates whether custom tip amounts are allowed during the checkout flow. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_tip_field")]
    public bool? CustomTipField { get; init; }

    /// <summary>
    /// Indicates whether tip options should be presented on the screen before presenting
    /// the signature screen during card payment. Defaults to false.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("separate_tip_screen")]
    public bool? SeparateTipScreen { get; init; }

    /// <summary>
    /// Enables the "Smart Tip Amounts" behavior.
    /// Exact tipping options depend on the region in which the Square seller is active.
    /// <para>
    /// For payments under 10.00, in the Australia, Canada, Ireland, United Kingdom, and United States, tipping options are presented as no tip, .50, 1.00 or 2.00.
    /// </para>
    /// <para>
    /// For payment amounts of 10.00 or greater, tipping options are presented as the following percentages: 0%, 5%, 10%, 15%.
    /// </para>
    /// <para>
    /// If set to true, the <c>tip_percentages</c> settings is ignored.
    /// Defaults to false.
    /// </para>
    /// <para>
    /// To learn more about smart tipping, see <see href="https://squareup.com/help/us/en/article/5069-accept-tips-with-the-square-app">Accept Tips with the Square App</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("smart_tipping")]
    public bool? SmartTipping { get; init; }

    /// <summary>
    /// A list of tip percentages that should be presented during the checkout flow, specified as
    /// up to 3 non-negative integers from 0 to 100 (inclusive). Defaults to 15, 20, and 25.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tip_percentages")]
    public IReadOnlyList<int>? TipPercentages { get; init; }
}
