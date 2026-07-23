using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// An additional seller-defined and customer-facing field to include on the invoice. For more information,
/// see <see href="https://developer.squareup.com/docs/invoices-api/overview#custom-fields">Custom fields</see>.
/// <para>
/// Adding custom fields to an invoice requires an
/// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
/// </para>
/// </summary>
public record InvoiceCustomField
{
    /// <summary>
    /// The label or title of the custom field. This field is required for a custom field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    [MaxLength(30)]
    public string? Label { get; init; }

    /// <summary>
    /// The location of the custom field on the invoice. This field is required for a custom field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("placement")]
    public string? Placement { get; init; }

    /// <summary>
    /// The text of the custom field. If omitted, only the label is rendered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    [MaxLength(2000)]
    public string? Value { get; init; }
}
