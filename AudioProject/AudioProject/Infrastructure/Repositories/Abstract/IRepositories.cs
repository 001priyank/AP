using AudioProject.Entities;
using System.Collections.Generic;

namespace AudioProject.Infrastructure.Repositories
{   
    public interface ILoggingRepository : IEntityBaseRepository<Error> { }
 
    public interface IRoleRepository : IEntityBaseRepository<Role> { }

    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleByUsername(string username);
        IEnumerable<Role> GetUserRoles(string username);
    }

    public interface IUserRoleRepository : IEntityBaseRepository<UserRole> { }
}
