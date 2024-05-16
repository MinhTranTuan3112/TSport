using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    public class Donation : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public int ClubId { get; set; }

        public int AccountId { get; set; }

        public int OrderId { get; set; }

        public DateTime DonationDate { get; set; }

        public double Value { get; set; }

        //Navigators
        public virtual Order Order { get; set; } = null!;

        public virtual Club Club { get; set; } = null!;

        public virtual Account Account { get; set; } = null!;
        
    }
}