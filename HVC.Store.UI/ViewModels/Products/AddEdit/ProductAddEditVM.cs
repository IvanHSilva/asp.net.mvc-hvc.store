using System;
using System.ComponentModel.DataAnnotations;

namespace HVC.Store.UI.ViewModels.Products.AddEdit {
    public class ProductAddEditVM {
        public ProductAddEditVM() {
            DateEntry = DateTime.Now;
            //DateEntry.ToString("dd/MM/yyyy");
        }

        public int Id { get; set; }
        [Required, StringLength(100)]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Preço")]
        public decimal Price { get; set; }
        [Display(Name = "Quantidade")]
        public short Quantity { get; set; }
        [Display(Name="Tipo de Produto")]
        public int ProductTypeId { get; set; }
        [Display(Name = "Data de Cadastro")]
        public DateTime DateEntry { get; set; }
    }
}
