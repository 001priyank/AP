using AudioProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Entities.OrderManagement
{
    public class Orders : IEntityBase
    {
        public int Id { get; set; }
        public User user { get; set; }
        public int UserId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        public List<OrderFiles> OrderFiles { get; set; }

    }
}
