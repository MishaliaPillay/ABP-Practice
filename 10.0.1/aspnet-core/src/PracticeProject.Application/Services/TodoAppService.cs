
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
        //private readonly IRepository<TodoItem, Guid> _todoItemRepository;
        //public async Task<List<TodoItemDto>> GetListAsync()
        //{
        //    var items = await _todoItemRepository.GetAllListAsync();
        //    return items
        //        .Select(item => new TodoItemDto
        //        {
        //            Id = item.Id,
        //            Text = item.Text
        //        }).ToList();
        //}

        //public async Task<TodoItemDto> CreateAsync(string text)
        //{
        //    var todoItem = await _todoItemRepository.InsertAsync(
        //        new TodoItem { Text = text }
        //    );

        //    return new TodoItemDto
        //    {
        //        Id = todoItem.Id,
        //        Text = todoItem.Text
        //    };
        //}
        //public async Task<TodoItemDto> UpdateAsync(Guid id, string newText, bool? isCompleted)
        //{

        //    var todoItem = await _todoItemRepository.GetAsync(id);
        //    if (todoItem == null)
        //    {
        //        throw new Exception("TodoItem not found.");
        //    }

        //    todoItem.Text = newText ?? todoItem.Text;
        //    if (isCompleted.HasValue)
        //    {
        //        todoItem.IsCompleted = isCompleted.Value;
        //    }

        //    await _todoItemRepository.UpdateAsync(todoItem);

        //    return new TodoItemDto
        //    {
        //        Id = todoItem.Id,
        //        Text = todoItem.Text
        //    };
        //}


        //public async Task DeleteAsync(Guid id)
        //{
        //    var todoItem = await _todoItemRepository.GetAsync(id);
        //    if (todoItem == null)
        //    {
        //        throw new Exception("TodoItem not found.");
        //    }


        //    todoItem.IsDeleted = true;


        //    await _todoItemRepository.UpdateAsync(todoItem);
        //}
        public TodoAppService(IRepository<TodoItem, Guid> repository)
    : base(repository)
        {
        }

    }
}
