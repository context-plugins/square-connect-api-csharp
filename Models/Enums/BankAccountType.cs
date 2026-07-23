using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the financial purpose of the bank account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankAccountType>))]
public sealed record BankAccountType : StringEnum<BankAccountType>
{
    private BankAccountType(string value) : base(value)
    {
    }

    /// <summary>
    /// An account at a financial institution against which checks can be
    /// drawn by the account depositor.
    /// </summary>
    public static readonly BankAccountType Checking = new("CHECKING");

    /// <summary>
    /// An account at a financial institution that pays interest but cannot be
    /// used directly as money in the narrow sense of a medium of exchange.
    /// </summary>
    public static readonly BankAccountType Savings = new("SAVINGS");

    /// <summary>
    /// An account at a financial institution that contains a deposit of funds
    /// and/or securities.
    /// </summary>
    public static readonly BankAccountType Investment = new("INVESTMENT");

    /// <summary>
    /// An account at a financial institution which cannot be described by the
    /// other types.
    /// </summary>
    public static readonly BankAccountType Other = new("OTHER");

    /// <summary>
    /// An account at a financial institution against which checks can be
    /// drawn specifically for business purposes (non-personal use).
    /// </summary>
    public static readonly BankAccountType BusinessChecking = new("BUSINESS_CHECKING");

    public static BankAccountType FromValue(string value) => FromValueCore(value);
}
