using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PracticeProject.Authorization;

namespace PracticeProject;

[DependsOn(
    typeof(PracticeProjectCoreModule),
    typeof(AbpAutoMapperModule))]
public class PracticeProjectApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<PracticeProjectAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(PracticeProjectApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
