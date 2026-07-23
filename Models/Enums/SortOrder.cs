using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The order (e.g., chronological or alphabetical) in which results from a request are returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SortOrder>))]
public sealed record SortOrder : StringEnum<SortOrder>
{
    private SortOrder(string value) : base(value)
    {
    }

    /// <summary>
    /// The results are returned in descending (e.g., newest-first or Z-A) order.
    /// </summary>
    public static readonly SortOrder Desc = new("DESC");

    /// <summary>
    /// The results are returned in ascending (e.g., oldest-first or A-Z) order.
    /// </summary>
    public static readonly SortOrder Asc = new("ASC");

    public static SortOrder FromValue(string value) => FromValueCore(value);
}
