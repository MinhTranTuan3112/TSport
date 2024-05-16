using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    public class Account : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public DateTime? Dob { get; set; }

        public string? Gender { get; set; } //Based on Gender enum

        public string? RefreshToken { get; set; }

        public DateTime? RefreshTokenExpireTime { get; set; }

        public int RoleId { get; set; }

        //Navigators
        public virtual Role Role { get; set; } = null!;

        public virtual ICollection<Shirt> CreatedShirts { get; set; } = [];

        public virtual ICollection<Shirt> ModifiedShirts { get; set; } = [];

        public virtual ICollection<Order> Orders { get; set; } = [];

        public virtual ICollection<Voucher> Vouchers { get; set; } = [];

        public virtual ICollection<Donation> Donations { get; set; } = [];

    }
}
