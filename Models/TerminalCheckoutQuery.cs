using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record TerminalCheckoutQuery
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public TerminalCheckoutQueryFilter? Filter { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public TerminalCheckoutQuerySort? Sort { get; init; }
}
