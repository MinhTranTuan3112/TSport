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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.Property(o => o.OrderDate)
                .HasDefaultValueSql("GETDATE()");

            builder.HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.CreatedAccount)
                    .WithMany(a => a.CreatedOrders)
                    .HasForeignKey(o => o.CreatedAccountId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.ModifiedAccount)
                    .WithMany(a => a.ModifiedOrders)
                    .HasForeignKey(a => a.ModifiedAccountId)
                    .OnDelete(DeleteBehavior.NoAction);


            builder.HasMany(o => o.Payments)
                    .WithOne(p => p.Order)
                    .HasForeignKey(p => p.OrderId)
                    .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
