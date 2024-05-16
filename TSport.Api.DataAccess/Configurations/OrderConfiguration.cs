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
            builder.Property(o => o.OrderDate)
                .HasDefaultValueSql("GETDATE()");

            builder.HasMany(o => o.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Account)
                    .WithMany(a => a.Orders)
                    .HasForeignKey(o => o.AccountId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Payment)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(o => o.PaymentId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Donation)
                    .WithOne(d => d.Order)
                    .HasForeignKey<Donation>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
