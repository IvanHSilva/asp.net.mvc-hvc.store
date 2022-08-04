using HVC.Store.Domain.Contracts.Repositories;
using HVC.Store.Domain.Entities;
using HVC.Store.UI.Controllers;
using HVC.Store.UI.ViewModels.Products.Index;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HVC.Store.Tests.UI.Controllers {
    [TestClass, TestCategory("Constrollers/ProductsController")]
    public class ProductsControllerTest {

        //ProductsController
        [TestMethod]
        public void IndexMethodMustBeReturnAViewWithCorrectModel() {
            //arrange
            var productsController = new ProductsController(
                    new ProductRepositoryFake(), new ProdTypeRepositoryFake()
                );

            //act
            var result = productsController.Index();
            var model = result.Model as IEnumerable<ProductIndexVM>;

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual(3, model.Count());
            Assert.IsNotNull(model);
        }

        public class ProductRepositoryFake : IProductRepository {
            public void Add(Product entity) {
                throw new NotImplementedException();
            }

            public void Delete(Product entity) {
                throw new NotImplementedException();
            }

            public void Dispose() {
                throw new NotImplementedException();
            }

            public void Edit(Product entity) {
                throw new NotImplementedException();
            }

            public IEnumerable<Product> Get() {
                var type1 = new ProductType() { Id = 1, Name = "Tipo1" };
                var type2 = new ProductType() { Id = 2, Name = "Tipo2" };
                return new List<Product>() {
                    new Product() {Id = 1, Name = "Prod1", Price = 1, Quantity = 1, ProductType = type1, DateEntry = DateTime.Today},
                    new Product() {Id = 2, Name = "Prod2", Price = 2, Quantity = 2, ProductType = type2, DateEntry = DateTime.Today},
                    new Product() {Id = 3, Name = "Prod3", Price = 3, Quantity = 3, ProductType = type1, DateEntry = DateTime.Today}
                };
            }

            public Product Get(int id) {
                throw new NotImplementedException();
            }

            public IEnumerable<Product> GetByName(string text) {
                throw new NotImplementedException();
            }
        }
        public class ProdTypeRepositoryFake : IProductTypeRepository {
            public void Add(ProductType entity) {
                throw new NotImplementedException();
            }

            public void Delete(ProductType entity) {
                throw new NotImplementedException();
            }

            public void Dispose() {
                throw new NotImplementedException();
            }

            public void Edit(ProductType entity) {
                throw new NotImplementedException();
            }

            public IEnumerable<ProductType> Get() {
                throw new NotImplementedException();
            }

            public ProductType Get(int id) {
                throw new NotImplementedException();
            }
        }

    }
}
