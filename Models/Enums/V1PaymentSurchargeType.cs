using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1PaymentSurchargeType>))]
public sealed record V1PaymentSurchargeType : StringEnum<V1PaymentSurchargeType>
{
    private V1PaymentSurchargeType(string value) : base(value)
    {
    }

    public static readonly V1PaymentSurchargeType Unknown = new("UNKNOWN");

    public static readonly V1PaymentSurchargeType AutoGratuity = new("AUTO_GRATUITY");

    public static readonly V1PaymentSurchargeType Custom = new("CUSTOM");

    public static V1PaymentSurchargeType FromValue(string value) => FromValueCore(value);
}
