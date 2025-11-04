using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configurations
{
    internal class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)

        {
            builder.Property(p => p.Id).UseIdentityColumn(10,10);
            builder.Property(p => p.Name).IsRequired().HasColumnType("VARCHAR(50)");
            builder.Property(p => p.Description).HasColumnType("VARCHAR(200)");
            builder.Property(p => p.Price).IsRequired().HasColumnType("DECIMAL(10,2)").IsRequired();
            builder.Property(p => p.IsActive).HasDefaultValue(false);
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.UpdatedAt).HasComputedColumnSql("GETDATE()");

        }
    }
}
