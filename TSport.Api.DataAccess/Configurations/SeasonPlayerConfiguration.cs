using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class SeasonPlayerConfiguration : IEntityTypeConfiguration<SeasonPlayer>
    {
        public void Configure(EntityTypeBuilder<SeasonPlayer> builder)
        {
            builder.HasOne(sp => sp.Player)
                .WithMany(p => p.SeasonPlayers)
                .HasForeignKey(sp => sp.PlayerId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(sp => sp.Season)
                    .WithMany(s => s.SeasonPlayers)
                    .HasForeignKey(sp => sp.SeasonId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}