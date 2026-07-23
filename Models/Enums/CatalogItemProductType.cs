using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The type of a CatalogItem. Connect V2 only allows the creation of <c>REGULAR</c> or <c>APPOINTMENTS_SERVICE</c> items.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CatalogItemProductType>))]
public sealed record CatalogItemProductType : StringEnum<CatalogItemProductType>
{
    private CatalogItemProductType(string value) : base(value)
    {
    }

    /// <summary>
    /// An ordinary item.
    /// </summary>
    public static readonly CatalogItemProductType Regular = new("REGULAR");

    /// <summary>
    /// A Square gift card.
    /// </summary>
    public static readonly CatalogItemProductType GiftCard = new("GIFT_CARD");

    /// <summary>
    /// A service that can be booked using the Square Appointments app.
    /// </summary>
    public static readonly CatalogItemProductType AppointmentsService = new("APPOINTMENTS_SERVICE");

    public static CatalogItemProductType FromValue(string value) => FromValueCore(value);
}
