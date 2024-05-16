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
    public class Club : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Name { get; set; }

        //Navigators

        public virtual ICollection<Shirt> Shirts { get; set; } = [];

        public virtual ICollection<SeasonClubPlayer> SeasonClubPlayers { get; set; } = [];

        public virtual ICollection<Donation> Donations { get; set; } = [];
    }
}
