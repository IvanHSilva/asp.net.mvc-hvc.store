using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HVC.Store.UI.Models {
    //[Table(nameof(Product))]
    [Table("Products")]
    public class Product: Entity {
        //[Key]
        //public int Id { get; set; }
        [Required, Column(TypeName ="varchar"), StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }
        //public string Type { get; set; }
        //[Column("Quantidade")]
        public short Quantity { get; set; }
        //public DateTime DateEntry { get; set; }

        public int ProductTypeId { get; set; }
        [ForeignKey(nameof(ProductTypeId))]
        public virtual ProductType ProductType { get; set; }
    }
}
