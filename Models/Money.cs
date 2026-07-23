using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
/// Fields that do not explicitly define whether they are signed or unsigned are
/// considered unsigned and can only hold positive amounts. For signed fields, the
/// sign of the value indicates the purpose of the money transfer. See
/// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
/// for more information.
/// </summary>
public record Money
{
    /// <summary>
    /// The amount of money, in the smallest denomination of the currency
    /// indicated by <c>currency</c>. For example, when <c>currency</c> is <c>USD</c>, <c>amount</c> is
    /// in cents. Monetary amounts can be positive or negative. See the specific
    /// field description to determine the meaning of the sign in a particular case.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public long? Amount { get; init; }

    /// <summary>
    /// The type of currency, in __ISO 4217 format__. For example, the currency
    /// code for US dollars is <c>USD</c>.
    /// <para>
    /// See <see href="https://developer.squareup.com/reference/square_2021-08-18/enums/Currency">Currency</see> for possible values.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }
}
