using Abp.Application.Services;
using PracticeProject.MultiTenancy.Dto;

namespace PracticeProject.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

