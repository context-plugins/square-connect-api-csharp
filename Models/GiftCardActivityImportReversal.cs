using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Present only when GiftCardActivityType is IMPORT_REVERSAL and GiftCardGANSource is OTHER
/// </summary>
public record GiftCardActivityImportReversal
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonPropertyName("amount_money")]
    public required Money AmountMoney { get; init; }
}
