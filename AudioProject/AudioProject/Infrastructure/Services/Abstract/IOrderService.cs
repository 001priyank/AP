using AudioProject.Entities.OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Services.Abstract
{
    public interface IOrderService
    {
        Orders GetDefaultOrder();
    }
}
