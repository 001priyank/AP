using System;

namespace AudioProject.Entities.OrderManagement
{
    public class OrderFiles : IEntityBase
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Orders Order { get; set; }
        public String FileName { get; set; }
    }
}
