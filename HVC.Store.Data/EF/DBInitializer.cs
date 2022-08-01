using HVC.Store.Domain.Entities;
using HVC.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HVC.Store.Data.EF {
    class DBInitializer : CreateDatabaseIfNotExists<HVCStoreDataContext> {
        protected override void Seed(HVCStoreDataContext context) {
            var meat = new ProductType() { Name = "Carnes" };
            var drink = new ProductType() { Name = "Bebidas" };
            var barbecue = new ProductType() { Name = "Churrasco" };
            var products = new List<Product>() {
            new Product() { Name = "Picanha", Quantity = 1, Price = 100.0M, DateEntry = DateTime.Parse("10/05/2015"), ProductType = meat },
            new Product() { Name = "Linguiça", Quantity = 2, Price = 30.0M, DateEntry = DateTime.Parse("18/08/2017"), ProductType = meat },
            new Product() { Name = "Frango a Passarinho",  Quantity = 3, Price = 40.0M, DateEntry = DateTime.Parse("05/07/2010"), ProductType = meat },
            new Product() { Name = "Carvão", Quantity = 1, Price = 25.0M, DateEntry = DateTime.Parse("25/01/2012"), ProductType = barbecue },
            new Product() { Name = "Cerveja", Quantity = 30, Price = 4.0M, DateEntry = DateTime.Parse("30/06/2011"), ProductType = drink},
            new Product() { Name = "Coca", Quantity = 5, Price = 10.0M, DateEntry = DateTime.Parse("07/03/2014"), ProductType = drink },
            new Product() { Name = "Suco de Uva", Quantity = 4, Price = 7.80M, DateEntry = DateTime.Parse("01/10/2016"), ProductType = drink },
            new Product() { Name = "Pão de Alho", Quantity = 5, Price = 7.0M, DateEntry = DateTime.Parse("07/07/2007"), ProductType = barbecue },
            new Product() { Name = "Acendedor", Quantity = 2, Price = 5.0M, DateEntry = DateTime.Parse("01/10/2010"), ProductType = barbecue },
        };
            context.products.AddRange(products);

            context.users.Add(new User() {
                Name = "Ivan Henriques",
                EMail = "ivanhenriquessilva@gmail.com",
                Password = "123456".Encrypt(),
            });

            context.SaveChanges();
        }
    }
}
