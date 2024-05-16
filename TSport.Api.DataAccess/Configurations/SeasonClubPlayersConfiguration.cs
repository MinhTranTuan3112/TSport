using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class SeasonClubPlayersConfiguration : IEntityTypeConfiguration<SeasonClubPlayer>
    {
        public void Configure(EntityTypeBuilder<SeasonClubPlayer> builder)
        {
            builder.HasKey(scp => new { scp.SeasonId, scp.ClubId, scp.PlayerId });
            builder.HasOne(e => e.Season)
                   .WithMany(s => s.SeasonClubPlayers)
                   .HasForeignKey(e => e.SeasonId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Club)
                    .WithMany(s => s.SeasonClubPlayers)
                    .HasForeignKey(e => e.ClubId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Player)
                   .WithMany(s => s.SeasonClubPlayers)
                   .HasForeignKey(e => e.PlayerId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}