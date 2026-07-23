using System.Text.Json.Serialization;
using SquareConnectApi.Core.Enum;

namespace SquareConnectApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<V1EmployeeRolePermissions>))]
public sealed record V1EmployeeRolePermissions : StringEnum<V1EmployeeRolePermissions>
{
    private V1EmployeeRolePermissions(string value) : base(value)
    {
    }

    public static readonly V1EmployeeRolePermissions RegisterAccessSalesHistory = new("REGISTER_ACCESS_SALES_HISTORY");

    public static readonly V1EmployeeRolePermissions RegisterApplyRestrictedDiscounts = new("REGISTER_APPLY_RESTRICTED_DISCOUNTS");

    public static readonly V1EmployeeRolePermissions RegisterChangeSettings = new("REGISTER_CHANGE_SETTINGS");

    public static readonly V1EmployeeRolePermissions RegisterEditItem = new("REGISTER_EDIT_ITEM");

    public static readonly V1EmployeeRolePermissions RegisterIssueRefunds = new("REGISTER_ISSUE_REFUNDS");

    public static readonly V1EmployeeRolePermissions RegisterOpenCashDrawerOutsideSale = new("REGISTER_OPEN_CASH_DRAWER_OUTSIDE_SALE");

    public static readonly V1EmployeeRolePermissions RegisterViewSummaryReports = new("REGISTER_VIEW_SUMMARY_REPORTS");

    public static V1EmployeeRolePermissions FromValue(string value) => FromValueCore(value);
}
