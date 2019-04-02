using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GMIS.Controllers
{
    public abstract class GMISControllerBase: AbpController
    {
        protected GMISControllerBase()
        {
            LocalizationSourceName = GMISConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
