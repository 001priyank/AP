using AudioProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioProject.Entities.Orders
{
    public class OrderTypeCategorys :  IEntityBase
    {
        public int Id { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }
        public List<OrderTypes> OrderTypes { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsVisible { get; set; }
    }
}
