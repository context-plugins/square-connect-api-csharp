using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1PaymentTaxInclusionType>))]
public sealed record V1PaymentTaxInclusionType : StringEnum<V1PaymentTaxInclusionType>
{
    private V1PaymentTaxInclusionType(string value) : base(value)
    {
    }

    public static readonly V1PaymentTaxInclusionType Additive = new("ADDITIVE");

    public static readonly V1PaymentTaxInclusionType Inclusive = new("INCLUSIVE");

    public static V1PaymentTaxInclusionType FromValue(string value) => FromValueCore(value);
}
