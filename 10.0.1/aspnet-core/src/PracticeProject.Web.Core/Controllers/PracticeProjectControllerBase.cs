using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PracticeProject.Controllers
{
    public abstract class PracticeProjectControllerBase : AbpController
    {
        protected PracticeProjectControllerBase()
        {
            LocalizationSourceName = PracticeProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
