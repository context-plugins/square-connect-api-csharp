using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Represents a phase in the process of calculating order totals.
/// Service charges are applied after the indicated phase.
/// <para>
/// <see href="https://developer.squareup.com/docs/orders-api/how-it-works#how-totals-are-calculated">Read more about how order totals are calculated.</see>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderServiceChargeCalculationPhase>))]
public sealed record OrderServiceChargeCalculationPhase : StringEnum<OrderServiceChargeCalculationPhase>
{
    private OrderServiceChargeCalculationPhase(string value) : base(value)
    {
    }

    /// <summary>
    /// The service charge is applied after discounts, but before
    /// taxes.
    /// </summary>
    public static readonly OrderServiceChargeCalculationPhase SubtotalPhase = new("SUBTOTAL_PHASE");

    /// <summary>
    /// The service charge is applied after all discounts and taxes
    /// are applied.
    /// </summary>
    public static readonly OrderServiceChargeCalculationPhase TotalPhase = new("TOTAL_PHASE");

    public static OrderServiceChargeCalculationPhase FromValue(string value) => FromValueCore(value);
}
