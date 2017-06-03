using AudioProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Entities.OrderManagement
{
    public class OrderItems : IEntityBase
    {
        public int Id { get; set; }
        public int OrderTypeId { get; set; }
        public string Description { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int OrderId { get; set; }
        public Orders Order { get; set; }        
        public int CompletionPercent { get; set; }

    }
}
