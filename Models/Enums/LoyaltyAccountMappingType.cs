using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The type of mapping.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoyaltyAccountMappingType>))]
public sealed record LoyaltyAccountMappingType : StringEnum<LoyaltyAccountMappingType>
{
    private LoyaltyAccountMappingType(string value) : base(value)
    {
    }

    /// <summary>
    /// The loyalty account is mapped by phone.
    /// </summary>
    public static readonly LoyaltyAccountMappingType Phone = new("PHONE");

    public static LoyaltyAccountMappingType FromValue(string value) => FromValueCore(value);
}
