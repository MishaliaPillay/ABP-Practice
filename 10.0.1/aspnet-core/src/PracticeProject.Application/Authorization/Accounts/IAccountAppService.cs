using Abp.Application.Services;
using PracticeProject.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace PracticeProject.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
