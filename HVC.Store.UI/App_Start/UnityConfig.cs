using HVC.Store.Data.EF.Repositories;
using HVC.Store.Domain.Contracts.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace HVC.Store.UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IProductRepository, ProductRepositoryEF>();
            container.RegisterType<IProductTypeRepository, ProductTypeRepositoryEF>();
            container.RegisterType<IUserRepository, UserRepositoryEF>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}