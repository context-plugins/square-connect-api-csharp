using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A defined break template that sets an expectation for possible <c>Break</c>
/// instances on a <c>Shift</c>.
/// </summary>
public record BreakType
{
    /// <summary>
    /// A human-readable name for this type of break. The name is displayed to
    /// employees in Square products.
    /// </summary>
    [JsonPropertyName("break_name")]
    [MinLength(1)]
    public required string BreakName { get; init; }

    /// <summary>
    /// A read-only timestamp in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Format: RFC-3339 P[n]Y[n]M[n]DT[n]H[n]M[n]S. The expected length of
    /// this break. Precision less than minutes is truncated.
    /// </summary>
    [JsonPropertyName("expected_duration")]
    [MinLength(1)]
    public required string ExpectedDuration { get; init; }

    /// <summary>
    /// The UUID for this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MaxLength(255)]
    public string? Id { get; init; }

    /// <summary>
    /// Whether this break counts towards time worked for compensation
    /// purposes.
    /// </summary>
    [JsonPropertyName("is_paid")]
    public required bool IsPaid { get; init; }

    /// <summary>
    /// The ID of the business location this type of break applies to.
    /// </summary>
    [JsonPropertyName("location_id")]
    [MinLength(1)]
    public required string LocationId { get; init; }

    /// <summary>
    /// A read-only timestamp in RFC 3339 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// Used for resolving concurrency issues. The request fails if the version
    /// provided does not match the server version at the time of the request. If a value is not
    /// provided, Square's servers execute a "blind" write; potentially
    /// overwriting another writer's data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }
}
