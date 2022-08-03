using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Sora.Auth.Configuration;
using Sora.Auth.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace Sora.Auth.Web.Startup
{
    [DependsOn(
        typeof(AuthApplicationModule), 
        typeof(AuthEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class AuthWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AuthWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AuthConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<AuthNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AuthApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AuthWebModule).Assembly);
        }
    }
}
