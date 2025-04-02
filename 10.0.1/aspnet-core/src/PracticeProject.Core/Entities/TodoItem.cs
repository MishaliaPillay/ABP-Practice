using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace PracticeProject.Entities
{
    public class TodoItem : AggregateRoot<Guid>
    {
        public string Text { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public bool IsCompleted { get; set; }
    }
}
