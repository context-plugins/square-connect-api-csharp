using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record CreateTerminalCheckoutRequest
{
    [JsonPropertyName("checkout")]
    public required TerminalCheckout Checkout { get; init; }

    /// <summary>
    /// A unique string that identifies this <c>CreateCheckout</c> request. Keys can be any valid string but
    /// must be unique for every <c>CreateCheckout</c> request.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency keys</see> for more information.
    /// </para>
    /// </summary>
    [JsonPropertyName("idempotency_key")]
    [StringLength(64, MinimumLength = 1)]
    public required string IdempotencyKey { get; init; }
}
