using HVC.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HVC.Store.UI.ViewModels.Products.Index.Maps {
    public static class Extensions {
        public static IEnumerable<ProductIndexVM> ToProductIndexVM(this IEnumerable<Product> products) {
            return products.Select(p => new ProductIndexVM() {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                ProdType = p.ProductType.Name,
                Quantity = p.Quantity,
                DateEntry = p.DateEntry
            });
        }
    }
}
