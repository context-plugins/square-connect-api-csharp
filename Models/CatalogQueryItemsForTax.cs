using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// The query filter to return the items containing the specified tax IDs.
/// </summary>
public record CatalogQueryItemsForTax
{
    /// <summary>
    /// A set of <c>CatalogTax</c> IDs to be used to find associated <c>CatalogItem</c>s.
    /// </summary>
    [JsonPropertyName("tax_ids")]
    public required IReadOnlyList<string> TaxIds { get; init; }
}
