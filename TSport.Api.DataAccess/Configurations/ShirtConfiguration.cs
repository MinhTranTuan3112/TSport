using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
        public class ShirtConfiguration : IEntityTypeConfiguration<Shirt>
        {
                public void Configure(EntityTypeBuilder<Shirt> builder)
                {
                        builder.ToTable("Shirt");
                        builder.Property(s => s.CreatedDate)
                                .HasDefaultValueSql("GETDATE()");

                        builder.HasOne(s => s.CreatedAccount)
                                .WithMany(a => a.CreatedShirts)
                                .HasForeignKey(s => s.CreatedAccountId)
                                .OnDelete(DeleteBehavior.Cascade);

                        builder.HasOne(s => s.ModifiedAccount)
                                .WithMany(a => a.ModifiedShirts)
                                .HasForeignKey(a => a.ModifiedAccountId)
                                .OnDelete(DeleteBehavior.NoAction);

                }
        }
}