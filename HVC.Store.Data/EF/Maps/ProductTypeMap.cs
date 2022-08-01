using HVC.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HVC.Store.Data.EF.Maps {
    public class ProductTypeMap : EntityTypeConfiguration<ProductType> {
        public ProductTypeMap() {
            //Table
            ToTable("ProdTypes");
            //Primary Key
            HasKey(pk => pk.Id);
            //Columns
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.DateEntry);
        }
    }
}
