using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.DataAccess.Configurations;
using TSport.Api.Models.Abstractions;
using TSport.Api.Models.Entities;

namespace TSport.Api.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<SeasonClubPlayer> SeasonClubPlayers { get; set; }

        public DbSet<Shirt> Shirts { get; set; }

        public DbSet<ShirtEdition> ShirtEditions { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Voucher> Vouchers { get; set; }

        public DbSet<Donation> Donations { get; set; }


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                          .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ClubConfiguration());
            modelBuilder.ApplyConfiguration(new DonationConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.ApplyConfiguration(new SeasonClubPlayersConfiguration());
            modelBuilder.ApplyConfiguration(new ShirtConfiguration());
            modelBuilder.ApplyConfiguration(new ShirtEditionConfiguration());

        }
    }
}
