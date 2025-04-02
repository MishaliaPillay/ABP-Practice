using Abp.Application.Services;
using PracticeProject.Sessions.Dto;
using System.Threading.Tasks;

namespace PracticeProject.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
