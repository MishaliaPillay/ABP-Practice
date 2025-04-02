using PracticeProject.Configuration.Dto;
using System.Threading.Tasks;

namespace PracticeProject.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
