using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record CreateOrderRequest
{
    /// <summary>
    /// A value you specify that uniquely identifies this
    /// order among orders you have created.
    /// <para>
    /// If you are unsure whether a particular order was created successfully,
    /// you can try it again with the same idempotency key without
    /// worrying about creating duplicate orders.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://developer.squareup.com/docs/basics/api101/idempotency">Idempotency</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("idempotency_key")]
    [MaxLength(192)]
    public string? IdempotencyKey { get; init; }

    /// <summary>
    /// Contains all information related to a single order to process with Square,
    /// including line items that specify the products to purchase. <c>Order</c> objects also
    /// include information about any associated tenders, refunds, and returns.
    /// <para>
    /// All Connect V2 Transactions have all been converted to Orders including all associated
    /// itemization data.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order")]
    public Order? Order { get; init; }
}
