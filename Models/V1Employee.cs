using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents one of a business's employees.
/// </summary>
public record V1Employee
{
    /// <summary>
    /// The IDs of the locations the employee is allowed to clock in at.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorized_location_ids")]
    public IReadOnlyList<string>? AuthorizedLocationIds { get; init; }

    /// <summary>
    /// The time when the employee entity was created, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// The employee's email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// An ID the merchant can set to associate the employee with an entity in another system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; init; }

    /// <summary>
    /// The employee's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public required string FirstName { get; init; }

    /// <summary>
    /// The employee's unique ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The employee's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public required string LastName { get; init; }

    /// <summary>
    /// The ids of the employee's associated roles. Currently, you can specify only one or zero roles per employee.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("role_ids")]
    public IReadOnlyList<string>? RoleIds { get; init; }

    /// <summary>
    /// Whether the employee is ACTIVE or INACTIVE. Inactive employees cannot sign in to Square Register.Merchants update this field from the Square Dashboard.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    /// <summary>
    /// The time when the employee entity was most recently updated, in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }
}
