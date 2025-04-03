using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace PracticeProject.Entities
{
    public class Vehicle : FullAuditedEntity<Guid>
    {
        public int NumberOfWindows { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
