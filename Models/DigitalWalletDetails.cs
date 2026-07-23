using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Additional details about <c>WALLET</c> type payments. Contains only non-confidential information.
/// </summary>
public record DigitalWalletDetails
{
    /// <summary>
    /// The status of the <c>WALLET</c> payment. The status can be <c>AUTHORIZED</c>, <c>CAPTURED</c>, <c>VOIDED</c>, or
    /// <c>FAILED</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    [MaxLength(50)]
    public string? Status { get; init; }
}
