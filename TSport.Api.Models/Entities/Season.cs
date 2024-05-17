using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    [Table("Season")]
    public class Season : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Code { get; set; }

        public required string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public required string Status { get; set; }

        public int? ClubId { get; set; }

        //Navigators

        public virtual Club? Club { get; set; }

        public virtual ICollection<SeasonPlayer> SeasonPlayers { get; set; } = [];

        public virtual ICollection<ShirtEdition> ShirtEditions { get; set; } = [];

    }
}