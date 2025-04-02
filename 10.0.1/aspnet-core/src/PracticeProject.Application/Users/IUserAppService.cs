using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PracticeProject.Roles.Dto;
using PracticeProject.Users.Dto;
using System.Threading.Tasks;

namespace PracticeProject.Users;

public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
{
    Task DeActivate(EntityDto<long> user);
    Task Activate(EntityDto<long> user);
    Task<ListResultDto<RoleDto>> GetRoles();
    Task ChangeLanguage(ChangeUserLanguageDto input);

    Task<bool> ChangePassword(ChangePasswordDto input);
}
