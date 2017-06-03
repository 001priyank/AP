using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Repositories.OrderManagement
{
    public class OrderRepository : EntityBaseRepository<Entities.OrderManagement.Orders>
    {
        public OrderRepository(AudioProjectContext context)
            : base(context)
        { }
    }
}
