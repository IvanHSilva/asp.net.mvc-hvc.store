using HVC.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HVC.Store.UI.Controllers {
    public class ProductsController:Controller {
        public ViewResult Index() {
            var products = new List<Product>() {
                new Product() { Id = 1, Name = "Picanha", Type = "Carnes", Quantity = 1, Price = 100.0M, DateEntry = DateTime.Parse("10/05/2015") },
                new Product() { Id = 2, Name = "Linguiça", Type = "Carnes", Quantity = 2, Price = 30.0M, DateEntry = DateTime.Parse("18/08/2017") },
                new Product() { Id = 3, Name = "Frango a Passarinho", Type = "Carnes", Quantity = 3, Price = 40.0M, DateEntry = DateTime.Parse("05/07/2010") },
                new Product() { Id = 4, Name = "Carvão", Type = "Churrasco", Quantity = 1, Price = 25.0M, DateEntry = DateTime.Parse("25/01/2012") },
                new Product() { Id = 5, Name = "Cerveja", Type = "Bebidas", Quantity = 30, Price = 4.0M, DateEntry = DateTime.Parse("30/06/2011") },
                new Product() { Id = 5, Name = "Coca", Type = "Bebidas", Quantity = 5, Price = 10.0M, DateEntry = DateTime.Parse("07/03/2014") },
            };
            return View(products);
        }
    }
}
