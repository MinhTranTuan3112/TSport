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
            builder.HasMany(se => se.OrderDetails)
                .WithOne(od => od.ShirtEdition)
                .HasForeignKey(od => od.ShirtEditionId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}