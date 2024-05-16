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
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasIndex(a => a.Email).IsUnique();

            builder.HasMany<Voucher>(a => a.Vouchers)
                    .WithMany(v => v.Accounts)
                    .UsingEntity("AccountVouchers",
                    l => l.HasOne(typeof(Voucher))
                         .WithMany()
                         .HasForeignKey("VoucherId")
                         .HasPrincipalKey(nameof(Voucher.Id))
                         .OnDelete(DeleteBehavior.Cascade),
                    r => r.HasOne(typeof(Account))
                            .WithMany()
                            .HasForeignKey("AccountId")
                            .HasPrincipalKey(nameof(Account.Id))
                            .OnDelete(DeleteBehavior.Cascade),
                    j => j.HasKey("AccountId", "VoucherId")
            );

            builder.HasOne(a => a.Role)
                    .WithMany(r => r.Accounts)
                    .HasForeignKey(a => a.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
