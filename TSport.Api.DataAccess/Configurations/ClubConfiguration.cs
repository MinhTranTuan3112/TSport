using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class ClubConfiguration : IEntityTypeConfiguration<Club>
    {
        public void Configure(EntityTypeBuilder<Club> builder)
        {
            builder.ToTable("Club");
            builder.HasIndex(c => c.Name).IsUnique();

            builder.HasMany(c => c.Seasons)
                    .WithOne(s => s.Club)
                    .HasForeignKey(s => s.ClubId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.CreatedAccount)
                    .WithMany(a => a.CreatedClubs)
                    .HasForeignKey(c => c.CreatedAccountId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.ModifiedAccount)
                    .WithMany(a => a.ModifiedClubs)
                    .HasForeignKey(c => c.ModifiedAccountId)
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
