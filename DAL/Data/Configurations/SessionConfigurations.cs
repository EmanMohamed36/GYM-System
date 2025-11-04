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
    internal class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(s => s.Id).UseIdentityColumn(1,1);
            builder.Property(s => s.Capacity).IsRequired();
            builder.Property(s => s.EndDate).IsRequired();
            builder.Property(s => s.StartDate).IsRequired();
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(s => s.UpdatedAt).HasComputedColumnSql("GETDATE()");

            builder.ToTable( t =>
            {
                t.HasCheckConstraint("CK_EndDateAfterStartDate", "[EndDate] > [StartDate]");
            });

            #region ConfigOneToManyRelationWithTrainer

            builder.HasOne(s => s.Trainer)
                    .WithMany(t => t.Sessions)
                    .HasForeignKey(s => s.TrainerId)
                    .IsRequired();

            #endregion

            #region ConfigOneToManeRelationWithCategory
            builder.HasOne(s => s.Category)
                    .WithMany(c => c.Sessions)
                    .HasForeignKey(s => s.CategoryId)
                    .IsRequired();

            #endregion
        }
    }
}
