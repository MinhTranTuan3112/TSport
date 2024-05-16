using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class DonationConfiguration : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.Property(d => d.DonationDate)
                    .HasDefaultValueSql("GETDATE()");

            builder.HasOne(d => d.Account)
                    .WithMany(a => a.Donations)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(d => d.Club)
                    .WithMany(c => c.Donations)
                    .HasForeignKey(d => d.ClubId)
                    .OnDelete(DeleteBehavior.Cascade);

                    

        }
    }
}