using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// V1EmployeeRole
/// </summary>
public record V1EmployeeRole
{
    /// <summary>
    /// The time when the employee entity was created, in ISO 8601 format. Is set by Square when the Role is created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The role's unique ID, Can only be set by Square.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// If true, employees with this role have all permissions, regardless of the values indicated in permissions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_owner")]
    public bool? IsOwner { get; init; }

    /// <summary>
    /// The role's merchant-defined name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The role's permissions.
    /// </summary>
    [JsonPropertyName("permissions")]
    public required IReadOnlyList<string> Permissions { get; init; }

    /// <summary>
    /// The time when the employee entity was most recently updated, in ISO 8601 format. Is set by Square when the Role updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
