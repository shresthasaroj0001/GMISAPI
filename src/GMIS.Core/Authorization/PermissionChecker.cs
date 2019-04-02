using Abp.Authorization;
using GMIS.Authorization.Roles;
using GMIS.Authorization.Users;

namespace GMIS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
