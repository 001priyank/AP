using AudioProject.Entities.OrderManagement;
using AudioProject.Infrastructure.Repositories.OrderManagement;
using AudioProject.Infrastructure.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private AudioProjectContext _context;
        private readonly OrderTypeService orderTypeService;
        private OrderRepository orderRepository;
        private OrderItemRepository orderItemRepository;
        private OrderFileRepository orderFileRepository;

        public OrderService (AudioProjectContext context)
        {
            _context = context;
            this.orderTypeService = new OrderTypeService(context);
            this.orderRepository = new OrderRepository(context);
            this.orderItemRepository = new OrderItemRepository(context);
            this.orderFileRepository = new OrderFileRepository(context);
        }

        public Orders GetDefaultOrder()
        {
            var audioCategories = orderTypeService.GetAllOrderCategories();
            var orderItems = new List<OrderItems>();
            var order = new Orders();
            foreach (var audioCategory in audioCategories)
            {
                foreach (var orderType in audioCategory.OrderTypes)
                {
                    var orderItem = new OrderItems();
                    orderItem.OrderTypeId = orderType.Id;
                    orderItem.OrderType = orderType;
                    orderItems.Add(orderItem);
                }
            }

            order.OrderItems = orderItems;
            return order;
        }

    }
}
