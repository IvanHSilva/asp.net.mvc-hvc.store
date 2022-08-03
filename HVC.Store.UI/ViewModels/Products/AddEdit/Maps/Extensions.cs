using HVC.Store.Domain.Entities;

namespace HVC.Store.UI.ViewModels.Products.AddEdit.Maps {
    public static class Extensions {
        public static ProductAddEditVM ToProductAddEditVM(this Product product) {
            return new ProductAddEditVM() {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ProductTypeId = product.ProductTypeId,
                Quantity = product.Quantity,
                DateEntry = product.DateEntry
            };
        }

        public static Product ToProduct(this ProductAddEditVM product) {
            return new Product() {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ProductTypeId = product.ProductTypeId,
                Quantity = product.Quantity,
                DateEntry = product.DateEntry
            };
        }
    }
}
