using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// A record representing an individual team member for a business.
/// </summary>
public record TeamMember
{
    /// <summary>
    /// An object that represents a team member's assignment to locations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assigned_locations")]
    public TeamMemberAssignedLocations? AssignedLocations { get; init; }

    /// <summary>
    /// The timestamp, in RFC 3339 format, describing when the team member was created.
    /// For example, "2018-10-04T04:00:00-07:00" or "2019-02-05T12:00:00Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The email address associated with the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The family name (that is, the last name) associated with the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// The given name (that is, the first name) associated with the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The unique ID for the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Whether the team member is the owner of the Square account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_owner")]
    public bool? IsOwner { get; init; }

    /// <summary>
    /// The team member's phone number, in E.164 format. For example:
    /// +14155552671 - the country code is 1 for US
    /// +551155256325 - the country code is 55 for BR
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// A second ID used to associate the team member with an entity in another system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference_id")]
    public string? ReferenceId { get; init; }

    /// <summary>
    /// Describes the status of the team member.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The timestamp, in RFC 3339 format, describing when the team member was last updated.
    /// For example, "2018-10-04T04:00:00-07:00" or "2019-02-05T12:00:00Z".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
