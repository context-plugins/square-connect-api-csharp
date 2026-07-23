using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record CalculateOrderResponse
{
    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }

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
