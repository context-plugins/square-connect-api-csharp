using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Defines the parameters that can be included in the body of
/// a request to the <see href="https://developer.squareup.com/reference/square_2021-08-18/apple-pay-api/register-domain">RegisterDomain</see> endpoint.
/// </summary>
public record RegisterDomainRequest
{
    /// <summary>
    /// A domain name as described in RFC-1034 that will be registered with ApplePay.
    /// </summary>
    [JsonPropertyName("domain_name")]
    [StringLength(255, MinimumLength = 1)]
    public required string DomainName { get; init; }
}
