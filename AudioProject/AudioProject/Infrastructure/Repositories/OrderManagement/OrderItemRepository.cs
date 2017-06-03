using AudioProject.Entities.OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Repositories.OrderManagement
{
    public class OrderItemRepository : EntityBaseRepository<OrderItems>
    {
        public OrderItemRepository(AudioProjectContext context)
            : base(context)
        { }
    }
}
