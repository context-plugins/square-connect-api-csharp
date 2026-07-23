using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The search criteria for the loyalty accounts.
/// </summary>
public record SearchLoyaltyAccountsRequestLoyaltyAccountQuery
{
    /// <summary>
    /// The set of customer IDs to use in the loyalty account search.
    /// <para>
    /// This cannot be combined with <c>mappings</c>.
    /// </para>
    /// <para>
    /// Max: 30 customer IDs
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_ids")]
    public IReadOnlyList<string>? CustomerIds { get; init; }

    /// <summary>
    /// The set of mappings to use in the loyalty account search.
    /// <para>
    /// This cannot be combined with <c>customer_ids</c>.
    /// </para>
    /// <para>
    /// Max: 30 mappings
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mappings")]
    public IReadOnlyList<LoyaltyAccountMapping>? Mappings { get; init; }
}
