using HVC.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HVC.Store.Data.EF.Maps {
    public class UserMap : EntityTypeConfiguration<User> {
        public UserMap() {
            //Table
            ToTable("Users");
            //Primary Key
            HasKey(pk => pk.Id);
            //Columns
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
            Property(c => c.EMail)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
            Property(c => c.Password)
                .HasColumnType("char")
                .HasMaxLength(88)
                .IsRequired();
            Property(c => c.DateEntry);
        }
    }
}
