using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    [Table("Shirt")]
    public class Shirt : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Code { get; set; }

        public required string Name { get; set; }

        public string? Origin { get; set; }

        public string? Material { get; set; }

        public string? Description { get; set; }

        public required string Status { get; set; } //Based on ShirtStatus enum

        public int ShirtEditionId { get; set; }

        //Navigators
        public virtual ShirtEdition ShirtEdition { get; set; } = null!;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];

    }
}