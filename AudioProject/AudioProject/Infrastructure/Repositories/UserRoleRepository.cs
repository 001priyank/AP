using AudioProject.Entities;

namespace AudioProject.Infrastructure.Repositories
{
    public class UserRoleRepository : EntityBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AudioProjectContext context)
            : base(context)
        { }
    }
}
