using HVC.Store.Domain.Contracts.Repositories;
using HVC.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HVC.Store.Data.EF.Repositories {
    public class UserRepositoryEF : RepositoryEF<User>, IUserRepository {
        public User Get(string email) {
            return _ctx.users.FirstOrDefault(u => u.EMail == email);
        }
    }
}
