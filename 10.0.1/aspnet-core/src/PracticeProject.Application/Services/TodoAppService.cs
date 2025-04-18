﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Authorization;
using PracticeProject.Domain.ToDos;
using PracticeProject.Services.Dtos;

namespace PracticeProject.Services
{
    [AbpAllowAnonymous]
    public class TodoAppService : AsyncCrudAppService<TodoItem, TodoItemDto, Guid>
    {
        public TodoAppService(IRepository<TodoItem, Guid> repository)
    : base(repository)
        {
        }



    }

}
