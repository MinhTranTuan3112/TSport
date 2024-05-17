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
    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Player");
            builder.HasIndex(p => p.Name).IsUnique();
            builder.HasOne(p => p.Club)
                    .WithMany(c => c.Players)
                    .HasForeignKey(p => p.ClubId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(s => s.CreatedAccount)
                                .WithMany(a => a.CreatedPlayers)
                                .HasForeignKey(s => s.CreatedAccountId)
                                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.ModifiedAccount)
                    .WithMany(a => a.ModifiedPlayers)
                    .HasForeignKey(a => a.ModifiedAccountId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
