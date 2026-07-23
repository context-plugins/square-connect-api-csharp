using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RiskEvaluationRiskLevel>))]
public sealed record RiskEvaluationRiskLevel : StringEnum<RiskEvaluationRiskLevel>
{
    private RiskEvaluationRiskLevel(string value) : base(value)
    {
    }

    /// <summary>
    /// Indicates Square is still evaluating the payment.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel Pending = new("PENDING");

    /// <summary>
    /// Indicates payment risk is within the normal range.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel Normal = new("NORMAL");

    /// <summary>
    /// Indicates elevated risk level associated with the payment.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel Moderate = new("MODERATE");

    /// <summary>
    /// Indicates significantly elevated risk level with the payment.
    /// </summary>
    public static readonly RiskEvaluationRiskLevel High = new("HIGH");

    public static RiskEvaluationRiskLevel FromValue(string value) => FromValueCore(value);
}
