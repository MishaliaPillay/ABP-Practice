using Abp.Authorization;
using Abp.Runtime.Session;
using PracticeProject.Configuration.Dto;
using System.Threading.Tasks;

namespace PracticeProject.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : PracticeProjectAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
