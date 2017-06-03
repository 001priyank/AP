using AudioProject.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Repositories.OrderType
{
    public class OrderTypeRepository : EntityBaseRepository<OrderTypes>
    {
        AudioProjectContext _context;
        public OrderTypeRepository(AudioProjectContext context)
            : base(context)
        {
            this._context = context;
        }
        public List<OrderTypes> GetAllOrderTypes()
        {
            var data = _context.OrderTypes.OrderBy(x => x.SortOrder).Include(c => c.OrderTypeDescriptions);
            return data.ToList();
        }
    }
}
