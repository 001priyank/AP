using AudioProject.Entities;

namespace AudioProject.Infrastructure.Repositories
{
    public class RoleRepository : EntityBaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(AudioProjectContext context)
            : base(context)
        { }
    }
}
