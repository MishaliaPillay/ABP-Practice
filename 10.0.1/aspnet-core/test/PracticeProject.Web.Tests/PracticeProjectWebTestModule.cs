using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PracticeProject.EntityFrameworkCore;
using PracticeProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PracticeProject.Web.Tests;

[DependsOn(
    typeof(PracticeProjectWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class PracticeProjectWebTestModule : AbpModule
{
    public PracticeProjectWebTestModule(PracticeProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(PracticeProjectWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(PracticeProjectWebMvcModule).Assembly);
    }
}