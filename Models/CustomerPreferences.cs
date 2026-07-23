using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents communication preferences for the customer profile.
/// </summary>
public record CustomerPreferences
{
    /// <summary>
    /// Indicates whether the customer has unsubscribed from marketing campaign emails. A value of <c>true</c> means that the customer chose to opt out of email marketing from the current Square seller or from all Square sellers. This value is read-only from the Customers API.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_unsubscribed")]
    public bool? EmailUnsubscribed { get; init; }
}
