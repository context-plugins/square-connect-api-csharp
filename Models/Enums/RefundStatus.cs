using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates a refund's current status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RefundStatus>))]
public sealed record RefundStatus : StringEnum<RefundStatus>
{
    private RefundStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The refund is pending.
    /// </summary>
    public static readonly RefundStatus Pending = new("PENDING");

    /// <summary>
    /// The refund has been approved by Square.
    /// </summary>
    public static readonly RefundStatus Approved = new("APPROVED");

    /// <summary>
    /// The refund has been rejected by Square.
    /// </summary>
    public static readonly RefundStatus Rejected = new("REJECTED");

    /// <summary>
    /// The refund failed.
    /// </summary>
    public static readonly RefundStatus Failed = new("FAILED");

    public static RefundStatus FromValue(string value) => FromValueCore(value);
}
