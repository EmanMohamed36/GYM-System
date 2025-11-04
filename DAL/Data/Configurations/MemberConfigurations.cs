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
    internal class MemberConfigurations : GymUserConfigurations<Member>,
                                          IEntityTypeConfiguration<Member> 
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.CreatedAt).HasColumnName("JoinDate")
                                              .HasDefaultValueSql("GETDATE()");
            builder.Property(m => m.UpdatedAt).HasComputedColumnSql("GETDATE()");


            builder.HasOne(m => m.HealthRecord)
                    .WithOne(h => h.Member)
                    .HasForeignKey<HealthRecord>(h => h.MemberId)
                    .IsRequired();


            base.Configure(builder);
        }
    }
}
