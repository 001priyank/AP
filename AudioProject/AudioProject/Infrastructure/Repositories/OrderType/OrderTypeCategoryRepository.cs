using AudioProject.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Repositories.OrderType
{
    public class OrderTypeCategoryRepository : EntityBaseRepository<OrderTypeCategorys>
    {
        AudioProjectContext _context;
        public OrderTypeCategoryRepository(AudioProjectContext context)
            : base(context)
        {
            this._context = context;
        }

        public List<OrderTypeCategorys> GetAllCategories()
        {
            var data = _context.OrderTypeCategorys.OrderBy(x => x.SortOrder).Include(c => c.OrderTypes).ThenInclude(t=> t.OrderTypeDescriptions).ToList();
           
            return data.ToList();
        }
    }
}
