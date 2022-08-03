using System;

namespace HVC.Store.UI.ViewModels.Products.Index {
    public class ProductIndexVM {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        public string ProdType { get; set; }
        public DateTime DateEntry { get; set; } = DateTime.Now;
    }
}
