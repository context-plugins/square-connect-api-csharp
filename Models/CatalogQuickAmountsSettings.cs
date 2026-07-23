using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A parent Catalog Object model represents a set of Quick Amounts and the settings control the amounts.
/// </summary>
public record CatalogQuickAmountsSettings
{
    /// <summary>
    /// Represents a set of Quick Amounts at this location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amounts")]
    public IReadOnlyList<CatalogQuickAmount>? Amounts { get; init; }

    /// <summary>
    /// Represents location's eligibility for auto amounts
    /// The boolean should be consistent with whether there are AUTO amounts in the <c>amounts</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eligible_for_auto_amounts")]
    public bool? EligibleForAutoAmounts { get; init; }

    /// <summary>
    /// Represents the option seller currently uses on Quick Amounts.
    /// </summary>
    [JsonPropertyName("option")]
    public required string Option { get; init; }
}
