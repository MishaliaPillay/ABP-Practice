using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PracticeProject.Domain.ToDos;

namespace PracticeProject.Services.Dtos
{
    [AutoMap(typeof(TodoItem))]
    public class TodoItemDto : EntityDto<Guid>
    {
        public string Text { get; set; } = string.Empty;

        public bool? IsCompleted { get; set; }
    }
}
