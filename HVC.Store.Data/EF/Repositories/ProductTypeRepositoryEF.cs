using HVC.Store.Domain.Contracts.Repositories;
using HVC.Store.Domain.Entities;

namespace HVC.Store.Data.EF.Repositories {
    public class ProductTypeRepositoryEF : RepositoryEF<ProductType>, IProductTypeRepository {}
}
