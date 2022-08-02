using HVC.Store.Domain.Entities;

namespace HVC.Store.Domain.Contracts.Repositories {
    public interface IUserRepository : IRepository<User> {
        User Get(string email);
    }
}
