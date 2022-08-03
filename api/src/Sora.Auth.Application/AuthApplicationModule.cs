using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Sora.Auth
{
    [DependsOn(
        typeof(AuthCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AuthApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthApplicationModule).GetAssembly());
        }
    }
}