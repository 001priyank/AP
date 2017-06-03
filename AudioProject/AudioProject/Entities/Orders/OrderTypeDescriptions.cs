using System;

namespace AudioProject.Entities.Orders
{
    public class OrderTypeDescriptions :  IEntityBase
    {
        public int Id { get; set; }
        public int OrderTypeId { get; set; }
        public OrderTypes OrderType { get; set; }
        public String Description  { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsVisible { get; set; }
    }
}
