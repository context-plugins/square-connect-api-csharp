using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the state of a tracked item quantity in the lifecycle of goods.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InventoryState>))]
public sealed record InventoryState : StringEnum<InventoryState>
{
    private InventoryState(string value) : base(value)
    {
    }

    /// <summary>
    /// The related quantity of items are in a custom state. <b>READ-ONLY</b>:
    /// the Inventory API cannot move quantities to or from this state.
    /// </summary>
    public static readonly InventoryState Custom = new("CUSTOM");

    /// <summary>
    /// The related quantity of items are on hand and available for sale.
    /// </summary>
    public static readonly InventoryState InStock = new("IN_STOCK");

    /// <summary>
    /// The related quantity of items were sold as part of an itemized
    /// transaction. Quantities in the <c>SOLD</c> state are no longer tracked.
    /// </summary>
    public static readonly InventoryState Sold = new("SOLD");

    /// <summary>
    /// The related quantity of items were returned through the Square Point
    /// of Sale application, but are not yet available for sale. <b>READ-ONLY</b>:
    /// the Inventory API cannot move quantities to or from this state.
    /// </summary>
    public static readonly InventoryState ReturnedByCustomer = new("RETURNED_BY_CUSTOMER");

    /// <summary>
    /// The related quantity of items are on hand, but not currently
    /// available for sale. <b>READ-ONLY</b>: the Inventory API cannot move
    /// quantities to or from this state.
    /// </summary>
    public static readonly InventoryState ReservedForSale = new("RESERVED_FOR_SALE");

    /// <summary>
    /// The related quantity of items were sold online. <b>READ-ONLY</b>: the
    /// Inventory API cannot move quantities to or from this state.
    /// </summary>
    public static readonly InventoryState SoldOnline = new("SOLD_ONLINE");

    /// <summary>
    /// The related quantity of items were ordered from a vendor but not yet
    /// received. <b>READ-ONLY</b>: the Inventory API cannot move quantities to or
    /// from this state.
    /// </summary>
    public static readonly InventoryState OrderedFromVendor = new("ORDERED_FROM_VENDOR");

    /// <summary>
    /// The related quantity of items were received from a vendor but are
    /// not yet available for sale. <b>READ-ONLY</b>: the Inventory API cannot move
    /// quantities to or from this state.
    /// </summary>
    public static readonly InventoryState ReceivedFromVendor = new("RECEIVED_FROM_VENDOR");

    /// <summary>
    /// The related quantity of items are in transit between locations.
    /// *READ-ONLY**: the Inventory API cannot move quantities to or from this
    /// state.
    /// </summary>
    public static readonly InventoryState InTransitTo = new("IN_TRANSIT_TO");

    /// <summary>
    /// A placeholder indicating that the related quantity of items are not
    /// currently tracked in Square. Transferring quantities from the <c>NONE</c> state
    /// to a tracked state (e.g., <c>IN_STOCK</c>) introduces stock into the system.
    /// </summary>
    public static readonly InventoryState None = new("NONE");

    /// <summary>
    /// The related quantity of items are lost or damaged and cannot be
    /// sold.
    /// </summary>
    public static readonly InventoryState Waste = new("WASTE");

    /// <summary>
    /// The related quantity of items were returned but not linked to a
    /// previous transaction. Unlinked returns are not tracked in Square.
    /// Transferring a quantity from <c>UNLINKED_RETURN</c> to a tracked state (e.g.,
    /// <c>IN_STOCK</c>) introduces new stock into the system.
    /// </summary>
    public static readonly InventoryState UnlinkedReturn = new("UNLINKED_RETURN");

    /// <summary>
    /// The related quantity of items that are part of a composition consisting one or more components.
    /// </summary>
    public static readonly InventoryState Composed = new("COMPOSED");

    /// <summary>
    /// The related quantity of items that are part of a component.
    /// </summary>
    public static readonly InventoryState Decomposed = new("DECOMPOSED");

    /// <summary>
    /// This state is not supported by this version of the Square API. We recommend that you upgrade the client to use the appropriate version of the Square API supporting this state.
    /// </summary>
    public static readonly InventoryState SupportedByNewerVersion = new("SUPPORTED_BY_NEWER_VERSION");

    public static InventoryState FromValue(string value) => FromValueCore(value);
}
