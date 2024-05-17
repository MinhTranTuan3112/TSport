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
    [Table("Account")]
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

        public required string Role { get; set; } //Based on Role enum

        public required string Status { get; set; }

        //Navigators
        public virtual ICollection<Shirt> CreatedShirts { get; set; } = [];

        public virtual ICollection<Shirt> ModifiedShirts { get; set; } = [];

        public virtual ICollection<ShirtEdition> CreatedShirtEditions { get; set; } = [];

        public virtual ICollection<ShirtEdition> ModifiedShirtEditions { get; set; } = [];

        public virtual ICollection<Season> CreatedSeasons { get; set; } = [];

        public virtual ICollection<Season> ModifiedSeasons { get; set; } = [];

        public virtual ICollection<Player> CreatedPlayers { get; set; } = [];

        public virtual ICollection<Player> ModifiedPlayers { get; set; } = [];

        public virtual ICollection<Club> CreatedClubs { get; set; } = [];

        public virtual ICollection<Club> ModifiedClubs { get; set; } = [];

        public virtual ICollection<Payment> CreatedPayments { get; set; } = [];

        public virtual ICollection<Payment> ModifiedPayments { get; set; } = [];

        public virtual ICollection<Order> CreatedOrders { get; set; } = [];

        public virtual ICollection<Order> ModifiedOrders { get; set; } = [];

    }
}
