using Abp.Application.Services;

namespace Sora.Auth
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AuthAppServiceBase : ApplicationService
    {
        protected AuthAppServiceBase()
        {
            LocalizationSourceName = AuthConsts.LocalizationSourceName;
        }
    }
}