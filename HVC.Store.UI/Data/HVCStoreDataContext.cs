using HVC.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVC.Store.UI.Data {
    public class HVCStoreDataContext:DbContext {
        //string connDB = "Data Source =.\\SQLSERVER;Initial Catalog = HVCStore; Integrated Security = True";
        public HVCStoreDataContext() : base("Data Source =.\\SQLSERVER; Initial Catalog = HVCStore; Integrated Security = True") {
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<Product> products { get; set; }
    }
}
