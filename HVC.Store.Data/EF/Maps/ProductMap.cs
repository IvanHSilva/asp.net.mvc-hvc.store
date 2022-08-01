using HVC.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HVC.Store.Data.EF.Maps {
    public class ProductMap : EntityTypeConfiguration<Product> {
        public ProductMap() {
            //Table
            ToTable("Products");
            //Primary Key
            HasKey(pk => pk.Id);
            //Colunas
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.Price)
                .HasColumnType("money");
            Property(c => c.Quantity);
                //.HasColumnName("Quantidade");
            Property(c => c.ProductTypeId);
            Property(c => c.DateEntry);
            //Relations
            HasRequired(prod => prod.ProductType)
                .WithMany(type => type.Products)
                .HasForeignKey(fk => fk.ProductTypeId);
        }
    }
}
