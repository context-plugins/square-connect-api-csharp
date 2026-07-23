using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record ListDeviceCodesRequest
{
    /// <summary>
    /// A pagination cursor returned by a previous call to this endpoint.
    /// Provide this to retrieve the next set of results for your original query.
    /// <para>
    /// See <see href="https://developer.squareup.com/docs/working-with-apis/pagination">Paginating results</see> for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cursor")]
    public string? Cursor { get; init; }

    /// <summary>
    /// If specified, only returns DeviceCodes of the specified location.
    /// Returns DeviceCodes of all locations if empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("location_id")]
    public string? LocationId { get; init; }

    /// <summary>
    /// If specified, only returns DeviceCodes targeting the specified product type.
    /// Returns DeviceCodes of all product types if empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_type")]
    public string? ProductType { get; init; }

    /// <summary>
    /// If specified, returns DeviceCodes with the specified statuses.
    /// Returns DeviceCodes of status <c>PAIRED</c> and <c>UNPAIRED</c> if empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public IReadOnlyList<string>? Status { get; init; }
}
