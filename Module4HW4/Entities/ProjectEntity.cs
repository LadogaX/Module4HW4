using System;
using System.Collections.Generic;
using Module4HW4.Entities;

namespace Module4HW4.Entities
{
    public class ProjectEntity
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }

        public List<EmployeeProjectEntity> EmployeeProjects { get; set; } = new List<EmployeeProjectEntity>();
        public int ClientId { get; set; }
        public ClientEntity Client { get; set; }
    }
}
