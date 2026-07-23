using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// The list of possible dispute states.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisputeState>))]
public sealed record DisputeState : StringEnum<DisputeState>
{
    private DisputeState(string value) : base(value)
    {
    }

    public static readonly DisputeState UnknownState = new("UNKNOWN_STATE");

    public static readonly DisputeState InquiryEvidenceRequired = new("INQUIRY_EVIDENCE_REQUIRED");

    public static readonly DisputeState InquiryProcessing = new("INQUIRY_PROCESSING");

    public static readonly DisputeState InquiryClosed = new("INQUIRY_CLOSED");

    public static readonly DisputeState EvidenceRequired = new("EVIDENCE_REQUIRED");

    public static readonly DisputeState Processing = new("PROCESSING");

    public static readonly DisputeState Won = new("WON");

    public static readonly DisputeState Lost = new("LOST");

    public static readonly DisputeState Accepted = new("ACCEPTED");

    public static readonly DisputeState WaitingThirdParty = new("WAITING_THIRD_PARTY");

    public static DisputeState FromValue(string value) => FromValueCore(value);
}
