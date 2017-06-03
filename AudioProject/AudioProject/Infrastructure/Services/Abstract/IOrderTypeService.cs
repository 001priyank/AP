using AudioProject.Entities.Orders;
using System.Collections.Generic;

namespace AudioProject.Infrastructure.Services.Abstract
{
    public interface IOrderTypeService
    {
        List<OrderTypeCategorys> GetAllOrderCategories();
    }
}
