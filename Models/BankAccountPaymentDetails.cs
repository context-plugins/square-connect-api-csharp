using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Additional details about BANK_ACCOUNT type payments.
/// </summary>
public record BankAccountPaymentDetails
{
    /// <summary>
    /// The ownership type of the bank account performing the transfer.
    /// The type can be <c>INDIVIDUAL</c>, <c>COMPANY</c>, or <c>UNKNOWN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_ownership_type")]
    [MaxLength(50)]
    public string? AccountOwnershipType { get; init; }

    /// <summary>
    /// ACH-specific details about <c>BANK_ACCOUNT</c> type payments with the <c>transfer_type</c> of <c>ACH</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach_details")]
    public Achdetails? AchDetails { get; init; }

    /// <summary>
    /// The name of the bank associated with the bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_name")]
    [MaxLength(100)]
    public string? BankName { get; init; }

    /// <summary>
    /// The two-letter ISO code representing the country the bank account is located in.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [StringLength(2, MinimumLength = 2)]
    public string? Country { get; init; }

    /// <summary>
    /// Information about errors encountered during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// Uniquely identifies the bank account for this seller and can be used
    /// to determine if payments are from the same bank account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fingerprint")]
    [MaxLength(255)]
    public string? Fingerprint { get; init; }

    /// <summary>
    /// The statement description as sent to the bank.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statement_description")]
    [MaxLength(1000)]
    public string? StatementDescription { get; init; }

    /// <summary>
    /// The type of the bank transfer. The type can be <c>ACH</c> or <c>UNKNOWN</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfer_type")]
    [MaxLength(50)]
    public string? TransferType { get; init; }
}
