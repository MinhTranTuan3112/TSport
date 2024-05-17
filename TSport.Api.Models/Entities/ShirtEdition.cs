using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    [Table("ShirtEdition")]
    public class ShirtEdition : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Code { get; set; }

        public required string Size { get; set; } //Based on ShirtSize enum

        public bool HasSignature { get; set; }

        public int CustomNumber { get; set; }

        public double Price { get; set; }

        public string? Color { get; set; }

        public string? Origin { get; set; }

        public string? Material { get; set; }

        public required string Status { get; set; } //Based on ShirtEdition enum

        public int SeasonId { get; set; }

        //Navigators
        public virtual ICollection<Shirt> Shirts { get; set; } = [];

        public virtual Season Season { get; set; } = null!;
        

    }
}