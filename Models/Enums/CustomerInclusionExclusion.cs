using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates whether customers should be included in, or excluded from,
/// the result set when they match the filtering criteria.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CustomerInclusionExclusion>))]
public sealed record CustomerInclusionExclusion : StringEnum<CustomerInclusionExclusion>
{
    private CustomerInclusionExclusion(string value) : base(value)
    {
    }

    /// <summary>
    /// Customers should be included in the result set when they match the
    /// filtering criteria.
    /// </summary>
    public static readonly CustomerInclusionExclusion Include = new("INCLUDE");

    /// <summary>
    /// Customers should be excluded from the result set when they match
    /// the filtering criteria.
    /// </summary>
    public static readonly CustomerInclusionExclusion Exclude = new("EXCLUDE");

    public static CustomerInclusionExclusion FromValue(string value) => FromValueCore(value);
}
