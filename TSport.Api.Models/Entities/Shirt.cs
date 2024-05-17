using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    public class Shirt : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Origin { get; set; }

        public string? Material { get; set; }

        public string? Description { get; set; }

        public int? PlayerId { get; set; }

        public int? ClubId { get; set; }

        public int? SeasonId { get; set; }

        //Navigators
        public virtual Player? Player { get; set; }

        public virtual Club? Club { get; set; }

        public virtual Season? Season { get; set; }

        public virtual ICollection<ShirtEdition> ShirtEditions { get; set; } = [];

        public virtual ICollection<Image> Images { get; set; } = [];

    }
}