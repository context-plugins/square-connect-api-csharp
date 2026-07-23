using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents a bank account. For more information about
/// linking a bank account to a Square account, see
/// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
/// </summary>
public record BankAccount
{
    /// <summary>
    /// The last few digits of the account number.
    /// </summary>
    [JsonPropertyName("account_number_suffix")]
    [MinLength(1)]
    public required string AccountNumberSuffix { get; init; }

    /// <summary>
    /// The financial purpose of the associated bank account.
    /// </summary>
    [JsonPropertyName("account_type")]
    public required string AccountType { get; init; }

    /// <summary>
    /// Read only. Name of actual financial institution.
    /// For example "Bank of America".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_name")]
    [MaxLength(100)]
    public string? BankName { get; init; }

    /// <summary>
    /// The ISO 3166 Alpha-2 country code where the bank account is based.
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; init; }

    /// <summary>
    /// Indicates whether it is possible for Square to send money to this bank account.
    /// </summary>
    [JsonPropertyName("creditable")]
    public required bool Creditable { get; init; }

    /// <summary>
    /// The 3-character ISO 4217 currency code indicating the operating
    /// currency of the bank account. For example, the currency code for US dollars
    /// is <c>USD</c>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Reference identifier that will be displayed to UK bank account owners
    /// when collecting direct debit authorization. Only required for UK bank accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit_mandate_reference_id")]
    public string? DebitMandateReferenceId { get; init; }

    /// <summary>
    /// Indicates whether it is possible for Square to take money from this
    /// bank account.
    /// </summary>
    [JsonPropertyName("debitable")]
    public required bool Debitable { get; init; }

    /// <summary>
    /// A Square-assigned, unique identifier for the bank account based on the
    /// account information. The account fingerprint can be used to compare account
    /// entries and determine if the they represent the same real-world bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; init; }

    /// <summary>
    /// Name of the account holder. This name must match the name
    /// on the targeted bank account record.
    /// </summary>
    [JsonPropertyName("holder_name")]
    [MinLength(1)]
    public required string HolderName { get; init; }

    /// <summary>
    /// The unique, Square-issued identifier for the bank account.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(30, MinimumLength = 1)]
    public required string Id { get; init; }

    /// <summary>
    /// The location to which the bank account belongs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// Primary identifier for the bank. For more information, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
    /// </summary>
    [JsonPropertyName("primary_bank_identification_number")]
    [MaxLength(40)]
    public required string PrimaryBankIdentificationNumber { get; init; }

    /// <summary>
    /// Client-provided identifier for linking the banking account to an entity
    /// in a third-party system (for example, a bank account number or a user identifier).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// Secondary identifier for the bank. For more information, see
    /// <see href="https://developer.squareup.com/docs/bank-accounts-api">Bank Accounts API</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secondary_bank_identification_number")]
    [MaxLength(40)]
    public string? SecondaryBankIdentificationNumber { get; init; }

    /// <summary>
    /// Read-only. The current verification status of this BankAccount object.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// The current version of the <c>BankAccount</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
