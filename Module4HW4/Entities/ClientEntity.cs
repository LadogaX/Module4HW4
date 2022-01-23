using System.Collections.Generic;
using Module4HW4.Entities;

namespace Module4HW4.Entities
{
    public class ClientEntity
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
#nullable enable
        public string? Adress { get; set; }
        public List<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();
    }
}
