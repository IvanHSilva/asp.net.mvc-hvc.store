using HVC.Store.Domain.Entities;
using System.Data.Entity;

namespace HVC.Store.Data.EF {
    public class HVCStoreDataContext : DbContext {
        //string connDB = "Data Source =.\\SQLSERVER; Initial Catalog = HVCStore; Integrated Security = True";
        public HVCStoreDataContext() : base("Data Source =.\\SQLSERVER; Initial Catalog = HVCStore; Integrated Security = True") {
            //public HVCStoreDataContext() : base("@StoreConn") {
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<Product> products { get; set; }
        public DbSet<ProductType> prodtypes { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new Maps.ProductMap());
            modelBuilder.Configurations.Add(new Maps.ProductTypeMap());
            modelBuilder.Configurations.Add(new Maps.UserMap());
        }
    }
}
