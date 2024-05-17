using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payment");

            builder.HasOne(p => p.CreatedAccount)
                    .WithMany(a => a.CreatedPayments)
                    .HasForeignKey(s => s.CreatedAccountId)
                    .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.ModifiedAccount)
                    .WithMany(a => a.ModifiedPayments)
                    .HasForeignKey(a => a.ModifiedAccountId)
                    .OnDelete(DeleteBehavior.NoAction);
        }
    }
}