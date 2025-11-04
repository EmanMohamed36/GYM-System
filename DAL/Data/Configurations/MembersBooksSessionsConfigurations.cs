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
    internal class MembersBooksSessionsConfigurations : IEntityTypeConfiguration<MembersBookSessions>
    {
       

        public void Configure(EntityTypeBuilder<MembersBookSessions> builder)
        {
            builder.HasKey(ms => new {ms.SessionId,ms.MemberId});
            builder.Ignore(ms => ms.Id);

            builder.Property(ms => ms.IsAttended).HasDefaultValue(false);

            builder.Property(ms => ms.CreatedAt)
                    .HasColumnName("BookingDate")
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(ms => ms.Member)
                    .WithMany(m => m.MembersBookSessions)
                    .HasForeignKey(ms => ms.MemberId)
                    .IsRequired();
            builder.HasOne(ms => ms.Session)
                    .WithMany(s => s.MembersBookSessions)
                    .HasForeignKey(ms => ms.SessionId)
                    .IsRequired();
        }
    }
}
