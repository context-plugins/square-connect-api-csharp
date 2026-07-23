using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record RetrieveCashDrawerShiftResponse
{
    /// <summary>
    /// This model gives the details of a cash drawer shift.
    /// The cash_payment_money, cash_refund_money, cash_paid_in_money,
    /// and cash_paid_out_money fields are all computed by summing their respective
    /// event types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash_drawer_shift")]
    public CashDrawerShift? CashDrawerShift { get; init; }

    /// <summary>
    /// Any errors that occurred during the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("errors")]
    public IReadOnlyList<Error>? Errors { get; init; }
}
