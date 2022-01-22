using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW3.Entities
{
    public class TitleEntity
    {
        public int TitleId { get; set; }
        public string Name { get; set; }

        public List<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();
    }
}
