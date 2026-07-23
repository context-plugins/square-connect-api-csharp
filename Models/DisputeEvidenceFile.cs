using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A file to be uploaded as dispute evidence.
/// </summary>
public record DisputeEvidenceFile
{
    /// <summary>
    /// The file name including the file extension. For example: "receipt.tiff".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filename")]
    [StringLength(40, MinimumLength = 1)]
    public string? Filename { get; init; }

    /// <summary>
    /// Dispute evidence files must be application/pdf, image/heic, image/heif, image/jpeg, image/png, or image/tiff formats.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filetype")]
    [StringLength(40, MinimumLength = 1)]
    public string? Filetype { get; init; }
}
