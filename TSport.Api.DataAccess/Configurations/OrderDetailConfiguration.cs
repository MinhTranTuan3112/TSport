﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(od => new { od.OrderId, od.ShirtId });

            builder.HasOne(od => od.Shirt)
                    .WithMany(s => s.OrderDetails)
                    .HasForeignKey(od => od.ShirtId)
                    .OnDelete(DeleteBehavior.NoAction);

            
        }
    }
}
