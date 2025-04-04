using System;
using Abp.AutoMapper;
using PracticeProject.Domain.ToDos;

namespace PracticeProject.Services.Dtos
{
    [AutoMap(typeof(TodoItemSLA))]
    public class TodoItemDtoSLA : TodoItemDto
    {

        public DateTime ExpectedCompletion { get; set; }

    }
}
