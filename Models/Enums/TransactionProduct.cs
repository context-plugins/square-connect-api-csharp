using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the Square product used to process a transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionProduct>))]
public sealed record TransactionProduct : StringEnum<TransactionProduct>
{
    private TransactionProduct(string value) : base(value)
    {
    }

    /// <summary>
    /// Square Point of Sale.
    /// </summary>
    public static readonly TransactionProduct Register = new("REGISTER");

    /// <summary>
    /// The Square Connect API.
    /// </summary>
    public static readonly TransactionProduct ExternalApi = new("EXTERNAL_API");

    /// <summary>
    /// A Square subscription for one of multiple products.
    /// </summary>
    public static readonly TransactionProduct Billing = new("BILLING");

    /// <summary>
    /// Square Appointments.
    /// </summary>
    public static readonly TransactionProduct Appointments = new("APPOINTMENTS");

    /// <summary>
    /// Square Invoices.
    /// </summary>
    public static readonly TransactionProduct Invoices = new("INVOICES");

    /// <summary>
    /// Square Online Store.
    /// </summary>
    public static readonly TransactionProduct OnlineStore = new("ONLINE_STORE");

    /// <summary>
    /// Square Payroll.
    /// </summary>
    public static readonly TransactionProduct Payroll = new("PAYROLL");

    /// <summary>
    /// A Square product that does not match any other value.
    /// </summary>
    public static readonly TransactionProduct Other = new("OTHER");

    public static TransactionProduct FromValue(string value) => FromValueCore(value);
}
