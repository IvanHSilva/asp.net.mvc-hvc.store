using HVC.Store.Domain.Contracts.Repositories;
using HVC.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HVC.Store.Data.EF.Repositories {
    public class ProductRepositoryEF : RepositoryEF<Product>, IProductRepository {
        public IEnumerable<Product> GetByName(string text) {
            return _ctx.products.Where(p => p.Name.Contains(text));
            //return from p in _ctx.products where p.Name.Contains(text) select p;
        }
    }
}
