using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The type of the accrual rule that defines how buyers can earn points.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyProgramAccrualRuleType>))]
public sealed record LoyaltyProgramAccrualRuleType : StringEnum<LoyaltyProgramAccrualRuleType>
{
    private LoyaltyProgramAccrualRuleType(string value) : base(value)
    {
    }

    /// <summary>
    /// A visit-based accrual rule. A buyer earns points for each visit.
    /// You can specify the minimum purchase required.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType Visit = new("VISIT");

    /// <summary>
    /// A spend-based accrual rule. A buyer earns points based on the amount
    /// spent.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType Spend = new("SPEND");

    /// <summary>
    /// An accrual rule based on an item variation. For example, accrue
    /// points for purchasing a coffee.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType ItemVariation = new("ITEM_VARIATION");

    /// <summary>
    /// An accrual rule based on an item category. For example, accrue points
    /// for purchasing any item in the "hot drink" category: coffee, tea, or hot cocoa.
    /// </summary>
    public static readonly LoyaltyProgramAccrualRuleType Category = new("CATEGORY");

    public static LoyaltyProgramAccrualRuleType FromValue(string value) => FromValueCore(value);
}
