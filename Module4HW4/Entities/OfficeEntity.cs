using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    public class OfficeEntity
    {
        public int OfficeId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }

        public List<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();
    }
}
