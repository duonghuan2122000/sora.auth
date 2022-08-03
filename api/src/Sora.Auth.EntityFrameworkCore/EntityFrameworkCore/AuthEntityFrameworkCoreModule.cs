using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Sora.Auth.EntityFrameworkCore
{
    [DependsOn(
        typeof(AuthCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class AuthEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthEntityFrameworkCoreModule).GetAssembly());
        }
    }
}