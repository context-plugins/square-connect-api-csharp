using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// When to calculate the taxes due on a cart.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TaxCalculationPhase>))]
public sealed record TaxCalculationPhase : StringEnum<TaxCalculationPhase>
{
    private TaxCalculationPhase(string value) : base(value)
    {
    }

    /// <summary>
    /// The fee is calculated based on the payment's subtotal.
    /// </summary>
    public static readonly TaxCalculationPhase TaxSubtotalPhase = new("TAX_SUBTOTAL_PHASE");

    /// <summary>
    /// The fee is calculated based on the payment's total.
    /// </summary>
    public static readonly TaxCalculationPhase TaxTotalPhase = new("TAX_TOTAL_PHASE");

    public static TaxCalculationPhase FromValue(string value) => FromValueCore(value);
}
