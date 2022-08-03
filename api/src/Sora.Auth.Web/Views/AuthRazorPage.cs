using Abp.AspNetCore.Mvc.Views;

namespace Sora.Auth.Web.Views
{
    public abstract class AuthRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AuthRazorPage()
        {
            LocalizationSourceName = AuthConsts.LocalizationSourceName;
        }
    }
}
