using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GMIS.Authorization;

namespace GMIS
{
    [DependsOn(
        typeof(GMISCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GMISApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GMISAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GMISApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
