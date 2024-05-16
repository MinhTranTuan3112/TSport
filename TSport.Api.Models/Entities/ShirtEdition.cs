using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    public class ShirtEdition : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Size { get; set; }

        public bool HasSignature { get; set; }

        public int CustomNumber { get; set; }

        public double Price { get; set; }

        public int EditionQuantity { get; set; }

        public int ShirtId { get; set; }

        //Navigators
        public virtual Shirt Shirt { get; set; } = null!;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];



    }
}