using Abp.AspNetCore.Mvc.Controllers;

namespace Sora.Auth.Web.Controllers
{
    public abstract class AuthControllerBase: AbpController
    {
        protected AuthControllerBase()
        {
            LocalizationSourceName = AuthConsts.LocalizationSourceName;
        }
    }
}