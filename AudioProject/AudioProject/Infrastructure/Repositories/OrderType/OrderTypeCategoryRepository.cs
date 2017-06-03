using AudioProject.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Repositories.OrderType
{
    public class OrderTypeCategoryRepository : EntityBaseRepository<OrderTypeCategorys>
    {
        public OrderTypeCategoryRepository(AudioProjectContext context)
            : base(context)
        { }
    }
}
