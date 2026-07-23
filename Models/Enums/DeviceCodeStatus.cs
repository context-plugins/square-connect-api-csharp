using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// DeviceCode.Status enum.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeviceCodeStatus>))]
public sealed record DeviceCodeStatus : StringEnum<DeviceCodeStatus>
{
    private DeviceCodeStatus(string value) : base(value)
    {
    }

    /// <summary>
    /// The status cannot be determined or does not exist.
    /// </summary>
    public static readonly DeviceCodeStatus Unknown = new("UNKNOWN");

    /// <summary>
    /// The device code is just created and unpaired.
    /// </summary>
    public static readonly DeviceCodeStatus Unpaired = new("UNPAIRED");

    /// <summary>
    /// The device code has been signed in and paired to a device.
    /// </summary>
    public static readonly DeviceCodeStatus Paired = new("PAIRED");

    /// <summary>
    /// The device code was unpaired and expired before it was paired.
    /// </summary>
    public static readonly DeviceCodeStatus Expired = new("EXPIRED");

    public static DeviceCodeStatus FromValue(string value) => FromValueCore(value);
}
