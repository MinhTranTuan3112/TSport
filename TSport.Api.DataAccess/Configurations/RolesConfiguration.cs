using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class RolesConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasMany(r => r.Permissions)
                    .WithOne(p => p.Role)
                    .HasForeignKey(p => p.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}