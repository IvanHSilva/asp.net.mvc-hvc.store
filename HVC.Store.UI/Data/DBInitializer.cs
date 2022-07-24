using HVC.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HVC.Store.UI.Data {
    class DBInitializer : CreateDatabaseIfNotExists<HVCStoreDataContext> {
        protected override void Seed(HVCStoreDataContext context) {
            var products = new List<Product>() {
                new Product() { Name = "Picanha", Type = "Carnes", Quantity = 1, Price = 100.0M, DateEntry = DateTime.Parse("10/05/2015") },
                new Product() { Name = "Linguiça", Type = "Carnes", Quantity = 2, Price = 30.0M, DateEntry = DateTime.Parse("18/08/2017") },
                new Product() { Name = "Frango a Passarinho", Type = "Carnes", Quantity = 3, Price = 40.0M, DateEntry = DateTime.Parse("05/07/2010") },
                new Product() { Name = "Carvão", Type = "Churrasco", Quantity = 1, Price = 25.0M, DateEntry = DateTime.Parse("25/01/2012") },
                new Product() { Name = "Cerveja", Type = "Bebidas", Quantity = 30, Price = 4.0M, DateEntry = DateTime.Parse("30/06/2011") },
                new Product() { Name = "Coca", Type = "Bebidas", Quantity = 5, Price = 10.0M, DateEntry = DateTime.Parse("07/03/2014") },
                new Product() { Name = "Suco de Uva", Type = "Bebidas", Quantity = 4, Price = 7.80M, DateEntry = DateTime.Parse("01/10/2016") },
            }; 
            context.products.AddRange(products);
            context.SaveChanges();
        }
    }
}