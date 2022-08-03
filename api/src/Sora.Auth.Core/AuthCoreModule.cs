using Abp.Modules;
using Abp.Reflection.Extensions;
using Sora.Auth.Localization;

namespace Sora.Auth
{
    public class AuthCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            AuthLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = AuthConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthCoreModule).GetAssembly());
        }
    }
}