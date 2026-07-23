using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SquareConnectApi.Models;

/// <summary>
/// Represents the service charge applied to the original order.
/// </summary>
public record OrderReturnServiceCharge
{
    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount_money")]
    public Money? AmountMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_money")]
    public Money? AppliedMoney { get; init; }

    /// <summary>
    /// The list of references to <c>OrderReturnTax</c> entities applied to the
    /// <c>OrderReturnServiceCharge</c>. Each <c>OrderLineItemAppliedTax</c> has a <c>tax_uid</c>
    /// that references the <c>uid</c> of a top-level <c>OrderReturnTax</c> that is being
    /// applied to the <c>OrderReturnServiceCharge</c>. On reads, the applied amount is
    /// populated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applied_taxes")]
    public IReadOnlyList<OrderLineItemAppliedTax>? AppliedTaxes { get; init; }

    /// <summary>
    /// The calculation phase after which to apply the service charge.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("calculation_phase")]
    public string? CalculationPhase { get; init; }

    /// <summary>
    /// The catalog object ID of the associated <see href="https://developer.squareup.com/reference/square_2021-08-18/objects/OrderServiceCharge">OrderServiceCharge</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_object_id")]
    [MaxLength(192)]
    public string? CatalogObjectId { get; init; }

    /// <summary>
    /// The version of the catalog object that this service charge references.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("catalog_version")]
    public long? CatalogVersion { get; init; }

    /// <summary>
    /// The name of the service charge.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    [MaxLength(255)]
    public string? Name { get; init; }

    /// <summary>
    /// The percentage of the service charge, as a string representation of
    /// a decimal number. For example, a value of <c>"7.25"</c> corresponds to a
    /// percentage of 7.25%.
    /// <para>
    /// Either <c>percentage</c> or <c>amount_money</c> should be set, but not both.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percentage")]
    [MaxLength(10)]
    public string? Percentage { get; init; }

    /// <summary>
    /// The service charge <c>uid</c> from the order containing the original
    /// service charge. <c>source_service_charge_uid</c> is <c>null</c> for
    /// unlinked returns.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_service_charge_uid")]
    [MaxLength(60)]
    public string? SourceServiceChargeUid { get; init; }

    /// <summary>
    /// Indicates whether the surcharge can be taxed. Service charges
    /// calculated in the <c>TOTAL_PHASE</c> cannot be marked as taxable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxable")]
    public bool? Taxable { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_money")]
    public Money? TotalMoney { get; init; }

    /// <summary>
    /// Represents an amount of money. <c>Money</c> fields can be signed or unsigned.
    /// Fields that do not explicitly define whether they are signed or unsigned are
    /// considered unsigned and can only hold positive amounts. For signed fields, the
    /// sign of the value indicates the purpose of the money transfer. See
    /// <see href="https://developer.squareup.com/docs/build-basics/working-with-monetary-amounts">Working with Monetary Amounts</see>
    /// for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_tax_money")]
    public Money? TotalTaxMoney { get; init; }

    /// <summary>
    /// A unique ID that identifies the return service charge only within this order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uid")]
    [MaxLength(60)]
    public string? Uid { get; init; }
}
