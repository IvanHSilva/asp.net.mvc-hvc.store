namespace HVC.Store.Domain.Entities {
    public class Product : Entity {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        public int ProductTypeId { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
