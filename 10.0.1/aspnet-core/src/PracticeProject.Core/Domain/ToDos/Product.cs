using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace PracticeProject.Domain.ToDos
{
    public class Product : FullAuditedEntity<int>
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
