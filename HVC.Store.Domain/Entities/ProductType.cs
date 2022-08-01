using System;
using System.Collections.Generic;

namespace HVC.Store.Domain.Entities {
    public class ProductType : Entity {
        public String Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
