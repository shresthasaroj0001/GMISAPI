using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace GMIS.Authorization
{
    public class GMISAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            context.CreatePermission(PermissionNames.Pages_DataInsert, L("DataInsert"));
            context.CreatePermission(PermissionNames.Pages_DataUpdate, L("Pages_DataUpdate"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, GMISConsts.LocalizationSourceName);
        }
    }
}
