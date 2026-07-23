using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the current verification status of a <c>BankAccount</c> object.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankAccountStatus>))]
public sealed record BankAccountStatus : StringEnum<BankAccountStatus>
{
    private BankAccountStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates that the verification process has started. Some features
    /// (for example, creditable or debitable) may be provisionally enabled on the bank
    /// account.
    /// </summary>
    public static readonly BankAccountStatus VerificationInProgress = new("VERIFICATION_IN_PROGRESS");

    /// <summary>
    /// Indicates that the bank account was successfully verified.
    /// </summary>
    public static readonly BankAccountStatus Verified = new("VERIFIED");

    /// <summary>
    /// Indicates that the bank account is disabled and is permanently unusable
    /// for funds transfer. A bank account can be disabled because of a failed verification
    /// attempt or a failed deposit attempt.
    /// </summary>
    public static readonly BankAccountStatus Disabled = new("DISABLED");

    public static BankAccountStatus FromValue(string value) => FromValueCore(value);
}
