using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HVC.Store.UI.Models {
    [Table("ProdTypes")]
    public class ProductType: Entity {
        //[Key]
        //public int Id { get; set; }
        [Required, Column(TypeName ="varchar"), StringLength(50)]
        public String Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
