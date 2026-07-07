using AppStore.Localization;
using System.Text.RegularExpressions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AppStore.Permissions;

public class AppStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AppStorePermissions.GroupName);

        var ProductPermission = myGroup.AddPermission(AppStorePermissions.ProductGroupName, L("Permission:Products"));
        ProductPermission.AddChild(AppStorePermissions.Create, L("Permission:Products.Create"));
        ProductPermission.AddChild(AppStorePermissions.Count, L("Permission:Products.Count"));
        ProductPermission.AddChild(AppStorePermissions.List, L("Permission:Products.List"));
        ProductPermission.AddChild(AppStorePermissions.Edit, L("Permission:Products.Edit"));
        ProductPermission.AddChild(AppStorePermissions.Delete, L("Permission:Products.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AppStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AppStoreResource>(name);
    }
}
