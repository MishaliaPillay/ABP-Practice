using Abp.Modules;
using Abp.Reflection.Extensions;
using PracticeProject.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace PracticeProject.Web.Host.Startup
{
    [DependsOn(
       typeof(PracticeProjectWebCoreModule))]
    public class PracticeProjectWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PracticeProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PracticeProjectWebHostModule).GetAssembly());
        }
    }
}
