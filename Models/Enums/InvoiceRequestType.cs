using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

/// <summary>
/// Indicates the type of the payment request. For more information, see
/// <see href="https://developer.squareup.com/docs/invoices-api/overview#payment-requests">Payment requests</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceRequestType>))]
public sealed record InvoiceRequestType : StringEnum<InvoiceRequestType>
{
    private InvoiceRequestType(string value) : base(value)
    {
    }

    /// <summary>
    /// A request for a balance payment. The balance amount is computed as follows:
    /// <para>
    /// - If the invoice specifies only a balance payment request, the balance amount is the
    /// total amount of the associated order.
    /// - If the invoice also specifies a deposit request, the balance amount is the amount
    /// remaining after the deposit.
    /// </para>
    /// <para>
    /// <c>INSTALLMENT</c> and <c>BALANCE</c> payment requests are not allowed in the same invoice.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestType Balance = new("BALANCE");

    /// <summary>
    /// A request for a deposit payment. You have the option of specifying
    /// an exact amount or a percentage of the total order amount. If you request a deposit,
    /// it must be due before any other payment requests.
    /// </summary>
    public static readonly InvoiceRequestType Deposit = new("DEPOSIT");

    /// <summary>
    /// A request for an installment payment. Installments allow buyers to pay the invoice over time. Installments can optionally be combined with a deposit.
    /// <para>
    /// Adding <c>INSTALLMENT</c> payment requests to an invoice requires an
    /// <see href="https://developer.squareup.com/docs/invoices-api/overview#invoices-plus-subscription">Invoices Plus subscription</see>.
    /// </para>
    /// </summary>
    public static readonly InvoiceRequestType Installment = new("INSTALLMENT");

    public static InvoiceRequestType FromValue(string value) => FromValueCore(value);
}
