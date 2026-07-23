using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record UpdateItemTaxesRequest
{
    /// <summary>
    /// IDs for the CatalogItems associated with the CatalogTax objects being updated.
    /// </summary>
    [JsonPropertyName("item_ids")]
    public required IReadOnlyList<string> ItemIds { get; init; }

    /// <summary>
    /// IDs of the CatalogTax objects to disable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxes_to_disable")]
    public IReadOnlyList<string>? TaxesToDisable { get; init; }

    /// <summary>
    /// IDs of the CatalogTax objects to enable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxes_to_enable")]
    public IReadOnlyList<string>? TaxesToEnable { get; init; }
}
