using EMS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EMS.Permissions;

public class EMSPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var emsGroup = context.AddGroup(EMSPermissions.GroupName, L("Permission:EMS"));
        
        var eventsPermission = emsGroup.AddPermission(EMSPermissions.Events.Default, L("Permission:Events"));

        eventsPermission.AddChild(EMSPermissions.Events.Create, L("Permission:Events.Create"));
        eventsPermission.AddChild(EMSPermissions.Events.Edit, L("Permission:Events.Edit"));
        eventsPermission.AddChild(EMSPermissions.Events.Delete, L("Permission:Events.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EMSResource>(name);
    }
}
