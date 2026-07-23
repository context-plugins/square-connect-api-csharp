using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the card transaction's current status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenderCardDetailsStatus>))]
public sealed record TenderCardDetailsStatus : StringEnum<TenderCardDetailsStatus>
{
    private TenderCardDetailsStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The card transaction has been authorized but not yet captured.
    /// </summary>
    public static readonly TenderCardDetailsStatus Authorized = new("AUTHORIZED");

    /// <summary>
    /// The card transaction was authorized and subsequently captured (i.e., completed).
    /// </summary>
    public static readonly TenderCardDetailsStatus Captured = new("CAPTURED");

    /// <summary>
    /// The card transaction was authorized and subsequently voided (i.e., canceled).
    /// </summary>
    public static readonly TenderCardDetailsStatus Voided = new("VOIDED");

    /// <summary>
    /// The card transaction failed.
    /// </summary>
    public static readonly TenderCardDetailsStatus Failed = new("FAILED");

    public static TenderCardDetailsStatus FromValue(string value) => FromValueCore(value);
}
