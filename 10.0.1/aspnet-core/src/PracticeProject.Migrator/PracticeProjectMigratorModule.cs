using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PracticeProject.Configuration;
using PracticeProject.EntityFrameworkCore;
using PracticeProject.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace PracticeProject.Migrator;

[DependsOn(typeof(PracticeProjectEntityFrameworkModule))]
public class PracticeProjectMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public PracticeProjectMigratorModule(PracticeProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(PracticeProjectMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            PracticeProjectConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PracticeProjectMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
