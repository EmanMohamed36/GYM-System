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
    internal class MembersAssignPlansConfigurations : IEntityTypeConfiguration<MembersAssignPlans>
    {
        public void Configure(EntityTypeBuilder<MembersAssignPlans> builder)

        {
            builder.HasKey(mp => new { mp.PlanId, mp.MemberId });
            builder.Ignore(mp => mp.Id);

            builder.Property(mp => mp.CreatedAt)
                    .HasColumnName("StartDate")
                    .HasDefaultValueSql("GETDATE()");

            builder.Property(mp => mp.EndDate).IsRequired();

            builder.HasOne(mp => mp.Member)
                    .WithMany(m => m.MemberPlans)
                    .HasForeignKey(mp => mp.MemberId)
                    .IsRequired();

            builder.HasOne(mp => mp.Plan)
                    .WithMany(p => p.MemberPlans)
                    .HasForeignKey(mp => mp.PlanId)
                    .IsRequired();


        }
    }
}
