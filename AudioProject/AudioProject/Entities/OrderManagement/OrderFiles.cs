using AudioProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Entities.OrderManagement
{
    public class OrderFiles : IEntityBase
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Orders Order { get; set; }
        public String FileName { get; set; }
    }
}
