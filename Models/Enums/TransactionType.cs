using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The transaction type used in the disputed payment.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionType>))]
public sealed record TransactionType : StringEnum<TransactionType>
{
    private TransactionType(string value) : base(value)
    {
    }

    public static readonly TransactionType Debit = new("DEBIT");

    public static readonly TransactionType Credit = new("CREDIT");

    public static TransactionType FromValue(string value) => FromValueCore(value);
}
