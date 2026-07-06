using System.Text.RegularExpressions;

namespace AppStore.Permissions;

public static class AppStorePermissions
{
    public const string GroupName = "AppStore";

    public const string ProductGroupName = GroupName + ".Product";
    public const string List = GroupName + ".List";
    public const string Create = ProductGroupName + ".Create";
    public const string Edit = ProductGroupName + ".Edit";
    public const string Delete = ProductGroupName + ".Delete";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
}
