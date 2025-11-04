using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configurations
{
    public class GymUserConfigurations<TEntity> :IEntityTypeConfiguration<TEntity>
        where TEntity : GymUser
    {
        public  void Configure(EntityTypeBuilder<TEntity> builder)

        {
            builder.Property(h => h.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(h => h.UpdatedAt).HasComputedColumnSql("GETDATE()");

            builder.Property(h => h.Id).UseIdentityColumn(1, 1);

            builder.Property(h => h.Name).IsRequired().HasColumnType("VARCHAR(50)");
            
            builder.Property(h => h.Email).IsRequired().HasColumnType("VARCHAR(100)");
            builder.HasIndex(e => e.Email).IsUnique();
            
            builder.Property(h => h.phone).HasColumnType("VARCHAR(11)");
            builder.HasIndex(e => e.phone).IsUnique();

            #region ConfigOwnedType

            builder.OwnsOne(h => h.Address, address =>
            {
                address.Property(a => a.BuildingNo)
                        .HasColumnName("BuildingNo")
                        .IsRequired();
                address.Property(a => a.Street)
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("Street")
                        .IsRequired();
                address.Property(a => a.City)
                        .HasColumnType("VARCHAR(30)")
                        .HasColumnName("City")
                        .IsRequired();

            });
            #endregion



        }
    }
}
