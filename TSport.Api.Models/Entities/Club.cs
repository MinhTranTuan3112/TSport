using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Models.Entities
{
    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Name { get; set; }

        //Navigators
        public virtual ICollection<Player> Players { get; set; } = [];

        public virtual ICollection<Product> Products { get; set; } = [];
    }
}
