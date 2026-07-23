using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1Settlement
/// </summary>
public record V1Settlement
{
    /// <summary>
    /// The Square-issued unique identifier for the bank account associated with the settlement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank_account_id")]
    public string? BankAccountId { get; init; }

    /// <summary>
    /// The entries included in this settlement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entries")]
    public IReadOnlyList<V1SettlementEntry>? Entries { get; init; }

    /// <summary>
    /// The settlement's unique identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The time when the settlement was submitted for deposit or withdrawal, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initiated_at")]
    public string? InitiatedAt { get; init; }

    /// <summary>
    /// The settlement's current status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_money")]
    public V1Money? TotalMoney { get; init; }
}
