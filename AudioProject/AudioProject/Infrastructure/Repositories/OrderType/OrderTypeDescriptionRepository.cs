using AudioProject.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Repositories.OrderType
{
    public class OrderTypeDescriptionRepository : EntityBaseRepository<OrderTypes>
    {
        public OrderTypeDescriptionRepository(AudioProjectContext context)
            : base(context)
        { }
    }
}
