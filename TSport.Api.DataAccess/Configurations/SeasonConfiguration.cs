using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(EntityTypeBuilder<Season> builder)
        {
            builder.ToTable("Season");
            builder.HasOne(s => s.CreatedAccount)
                                .WithMany(a => a.CreatedSeasons)
                                .HasForeignKey(s => s.CreatedAccountId)
                                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.ModifiedAccount)
                    .WithMany(a => a.ModifiedSeasons)
                    .HasForeignKey(a => a.ModifiedAccountId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.ShirtEditions)
                    .WithOne(se => se.Season)
                    .HasForeignKey(se => se.SeasonId)
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}