using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace PracticeProject.Domain.ToDos
{
    public class TodoItem : FullAuditedEntity<Guid>
    {
        public string Text { get; set; } = string.Empty;

        public bool? IsCompleted { get; set; }
    }

}
