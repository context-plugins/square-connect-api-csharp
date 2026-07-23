using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Specifies which timestamp to use to sort <c>SearchOrder</c> results.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SearchOrdersSortField>))]
public sealed record SearchOrdersSortField : StringEnum<SearchOrdersSortField>
{
    private SearchOrdersSortField(string value) : base(value)
    {
    }

    /// <summary>
    /// The time when the order was created, in RFC-3339 format. If you are also
    /// filtering for a time range in this query, you must set the <c>CREATED_AT</c>
    /// field in your <c>DateTimeFilter</c>.
    /// </summary>
    public static readonly SearchOrdersSortField CreatedAt = new("CREATED_AT");

    /// <summary>
    /// The time when the order last updated, in RFC-3339 format. If you are also
    /// filtering for a time range in this query, you must set the <c>UPDATED_AT</c>
    /// field in your <c>DateTimeFilter</c>.
    /// </summary>
    public static readonly SearchOrdersSortField UpdatedAt = new("UPDATED_AT");

    /// <summary>
    /// The time when the order was closed, in RFC-3339 format. If you use this
    /// value, you must also set a <c>StateFilter</c> with closed states. If you are also
    /// filtering for a time range in this query, you must set the <c>CLOSED_AT</c>
    /// field in your <c>DateTimeFilter</c>.
    /// </summary>
    public static readonly SearchOrdersSortField ClosedAt = new("CLOSED_AT");

    public static SearchOrdersSortField FromValue(string value) => FromValueCore(value);
}
