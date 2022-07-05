using Amnil.BookPublication.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Amnil.BookPublication.Permissions;

public class BookPublicationPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookPublicationPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookPublicationPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookPublicationResource>(name);
    }
}
