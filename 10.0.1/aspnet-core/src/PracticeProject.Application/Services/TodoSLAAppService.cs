
using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using PracticeProject.Domain.ToDos;
using PracticeProject.Services.Dtos;

namespace PracticeProject.Services
{
    [AbpAllowAnonymous]
    public class TodoSLAAppService : AsyncCrudAppService<TodoItemSLA, TodoItemDtoSLA, Guid>
    { 
        public TodoSLAAppService(IRepository<TodoItemSLA, Guid> repository)
    : base(repository)
        {
        }

        public override Task<TodoItemDtoSLA> CreateAsync(TodoItemDtoSLA input)
        {
            return base.CreateAsync(input);
        }
    }

}
