using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class ShirtEditionConfiguration : IEntityTypeConfiguration<ShirtEdition>
    {
        public void Configure(EntityTypeBuilder<ShirtEdition> builder)
        {
            builder.ToTable("ShirtEdition");

            builder.HasOne(s => s.CreatedAccount)
                                .WithMany(a => a.CreatedShirtEditions)
                                .HasForeignKey(s => s.CreatedAccountId)
                                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.ModifiedAccount)
                    .WithMany(a => a.ModifiedShirtEditions)
                    .HasForeignKey(a => a.ModifiedAccountId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(se => se.Shirts)
                .WithOne(s => s.ShirtEdition)
                .HasForeignKey(se => se.ShirtEditionId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}