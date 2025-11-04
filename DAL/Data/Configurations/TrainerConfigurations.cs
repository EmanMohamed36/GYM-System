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
    internal class TrainerConfigurations : GymUserConfigurations<Trainer>,
                                         IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        { 

            builder.Property(t => t.CreatedAt)
                   .HasColumnName("HireDate")            
                   .HasDefaultValueSql("GETDATE()");
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(s => s.UpdatedAt).HasComputedColumnSql("GETDATE()");


            base.Configure(builder);
        }
    }
}
