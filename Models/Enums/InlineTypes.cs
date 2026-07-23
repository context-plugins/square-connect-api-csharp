using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Object types to inline under their respective parent object in certain connect v2 responses
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InlineTypes>))]
public sealed record InlineTypes : StringEnum<InlineTypes>
{
    private InlineTypes(string value) : base(value)
    {
    }

    public static readonly InlineTypes InlineNone = new("INLINE_NONE");

    public static readonly InlineTypes InlineVariations = new("INLINE_VARIATIONS");

    public static readonly InlineTypes InlineAll = new("INLINE_ALL");

    public static InlineTypes FromValue(string value) => FromValueCore(value);
}
