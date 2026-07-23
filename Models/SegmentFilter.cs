using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A query filter to search for appointment segments by.
/// </summary>
public record SegmentFilter
{
    /// <summary>
    /// The ID of the <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/CatalogItemVariation">CatalogItemVariation</see> representing the service booked in this segment.
    /// </summary>
    [JsonPropertyName("service_variation_id")]
    [MinLength(1)]
    public required string ServiceVariationId { get; init; }

    /// <summary>
    /// A filter to select resources based on an exact field value. For any given
    /// value, the value can only be in one property. Depending on the field, either
    /// all properties can be set or only a subset will be available.
    /// <para>
    /// Refer to the documentation of the field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_member_id_filter")]
    public FilterValue? TeamMemberIdFilter { get; init; }
}
