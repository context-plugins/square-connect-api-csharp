using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

public record TerminalRefundQuery
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("filter")]
    public TerminalRefundQueryFilter? Filter { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sort")]
    public TerminalRefundQuerySort? Sort { get; init; }
}
