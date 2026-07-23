using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Defines supported stock levels of the item inventory.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SearchCatalogItemsRequestStockLevel>))]
public sealed record SearchCatalogItemsRequestStockLevel : StringEnum<SearchCatalogItemsRequestStockLevel>
{
    private SearchCatalogItemsRequestStockLevel(string value) : base(value)
    {
    }

    /// <summary>
    /// The item inventory is empty.
    /// </summary>
    public static readonly SearchCatalogItemsRequestStockLevel Out = new("OUT");

    /// <summary>
    /// The item inventory is low.
    /// </summary>
    public static readonly SearchCatalogItemsRequestStockLevel Low = new("LOW");

    public static SearchCatalogItemsRequestStockLevel FromValue(string value) => FromValueCore(value);
}
