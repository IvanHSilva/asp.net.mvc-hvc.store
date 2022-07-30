using HVC.Store.UI.Models;
using System.Data.Entity;

namespace HVC.Store.UI.Data {
    public class HVCStoreDataContext:DbContext {
        //string connDB = "Data Source =.\\SQLSERVER; Initial Catalog = HVCStore; Integrated Security = True";
        public HVCStoreDataContext() : base("Data Source =.\\SQLSERVER; Initial Catalog = HVCStore; Integrated Security = True") {
        //public HVCStoreDataContext() : base("@StoreConn") {
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<Product> products { get; set; }
        public DbSet<ProductType> prodtypes { get; set; }
        public DbSet<User> users { get; set; }
    }
}
