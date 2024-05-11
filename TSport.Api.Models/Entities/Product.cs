using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Models.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public required string Size { get; set; } //Based on ShirtSize enum

        public string? Description { get; set; }

        public int ClubId { get; set; }

        //Navigators
        public virtual Club Club { get; set; } = null!;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = [];
    }
}
