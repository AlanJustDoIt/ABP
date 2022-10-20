using ABP_PhoneBook.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABP_PhoneBook.Permissions;

public class ABP_PhoneBookPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABP_PhoneBookPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABP_PhoneBookPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABP_PhoneBookResource>(name);
    }
}
