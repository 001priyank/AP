using AudioProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Entities.Orders
{
    public class OrderTypes :  IEntityBase
    {
        public int Id { get; set; }
        public String OrderTypeName { get; set; }
        public String OrderTypeDisplayName { get; set; }
        public float Price { get; set; }
        public float PriceFuture { get; set; }
        public List<OrderTypeDescriptions> OrderTypeDescriptions { get; set; }
        public int OrderTypeCategoryId { get; set; }
        public OrderTypeCategorys OrderTypeCategory { get; set; }
        public bool Selected { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsVisible { get; set; }
    }
}
