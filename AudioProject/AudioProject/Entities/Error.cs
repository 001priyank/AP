using AudioProject.Entities;
using System;

namespace AudioProject.Entities
{
    public class Error : ClientChangeTracker, IEntityBase
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
