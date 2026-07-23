using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the fields that are included in requests to the
/// <see href="https://developer.squareup.com/reference/square_2021-08-18/orders-api/update-order">UpdateOrder</see> endpoint.
/// </summary>
public record UpdateOrderRequest
{
    /// <summary>
    /// The <see href="https://developer.squareup.com/docs/orders-api/manage-orders#on-dot-notation">dot notation paths</see>
    /// fields to clear. For example, <c>line_items[uid].note</c>.
    /// For more information, see <see href="https://developer.squareup.com/docs/orders-api/manage-orders#delete-fields">Deleting fields</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields_to_clear")]
    public IReadOnlyList<string>? FieldsToClear { get; init; }

    /// <summary>
    /// A value you specify that uniquely identifies this update request.
    /// <para>
    /// If you are unsure whether a particular update was applied to an order successfully,
    /// you can reattempt it with the same idempotency key without
    /// worrying about creating duplicate updates to the order.
    /// The latest order version is returned.
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
