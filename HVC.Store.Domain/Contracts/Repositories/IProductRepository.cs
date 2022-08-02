using HVC.Store.Domain.Entities;
using System.Collections.Generic;

namespace HVC.Store.Domain.Contracts.Repositories {
    public interface IProductRepository : IRepository<Product> {
        IEnumerable<Product> GetByName(string text);
    }
}
