using InstrumentalHub.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace InstrumentalHub.Permissions;

public class InstrumentalHubPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(InstrumentalHubPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(InstrumentalHubPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InstrumentalHubResource>(name);
    }
}
