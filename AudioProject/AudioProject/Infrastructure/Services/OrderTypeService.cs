using AudioProject.Entities.Orders;
using AudioProject.Infrastructure.Repositories.OrderType;
using AudioProject.Infrastructure.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Services
{
    public class OrderTypeService : IOrderTypeService
    {
        private readonly OrderTypeCategoryRepository orderTypeCategoryRepository;
        private readonly OrderTypeDescriptionRepository orderTypeDescriptionRepository;
        private readonly OrderTypeRepository orderTypeRepository;
        private readonly AudioProjectContext _audioProjectContext;
        public OrderTypeService(AudioProjectContext audioProjectContext)
        {
            this._audioProjectContext = audioProjectContext;
            this.orderTypeCategoryRepository = new OrderTypeCategoryRepository(audioProjectContext);
            this.orderTypeDescriptionRepository = new OrderTypeDescriptionRepository(audioProjectContext);
            this.orderTypeRepository = new OrderTypeRepository(audioProjectContext);
        }

        public List<OrderTypeCategorys> GetAllOrderCategories()
        {
            var data = orderTypeCategoryRepository.GetAllCategories();
            return data;
        }

    }
}
