using AudioProject.Entities;

namespace AudioProject.Entities
{
    public class Role : ClientChangeTracker, IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
