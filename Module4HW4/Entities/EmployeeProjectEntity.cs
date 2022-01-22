using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    public class EmployeeProjectEntity
    {
        public int EmployeeProjectId { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }

        public int ProjectId { get; set; }

        public ProjectEntity Projects { get; set; }

        public int EmployeeId { get; set; }

        public EmployeeEntity Employees { get; set; }
    }
}
