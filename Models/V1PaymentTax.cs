using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1PaymentTax
/// </summary>
public record V1PaymentTax
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_money")]
    public V1Money? AppliedMoney { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

    /// <summary>
    /// The ID of the tax, if available. Taxes applied in older versions of Square Register might not have an ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fee_id")]
    public string? FeeId { get; init; }

    /// <summary>
    /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inclusion_type")]
    public string? InclusionType { get; init; }

    /// <summary>
    /// The merchant-defined name of the tax.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The rate of the tax, as a string representation of a decimal number. A value of 0.07 corresponds to a rate of 7%.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rate")]
    public string? Rate { get; init; }
}
