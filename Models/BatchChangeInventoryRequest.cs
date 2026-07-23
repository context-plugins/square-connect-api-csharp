using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record BatchChangeInventoryRequest
{
    /// <summary>
    /// The set of physical counts and inventory adjustments to be made.
    /// Changes are applied based on the client-supplied timestamp and may be sent
    /// out of order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changes")]
    public IReadOnlyList<InventoryChange>? Changes { get; init; }

    /// <summary>
    /// A client-supplied, universally unique identifier (UUID) for the
    /// request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency</see> in the
    /// <see href="https://developer.squareup.com/docs/basics/api101/overview">API Development 101</see> section for more
    /// information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(128, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }

    /// <summary>
    /// Indicates whether the current physical count should be ignored if
    /// the quantity is unchanged since the last physical count. Default: <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ignore_unchanged_counts")]
    public bool? IgnoreUnchangedCounts { get; init; }
}
