using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class ImagesConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasOne(i => i.Shirt)
                    .WithMany(s => s.Images)
                    .HasForeignKey(i => i.ShirtId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}