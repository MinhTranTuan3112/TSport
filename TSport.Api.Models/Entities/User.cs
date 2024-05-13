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
    public class User : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string FullName { get; set; }

        public required string UserName { get; set; }

        public int AccountId { get; set; }

        //Navigators
        public virtual Account Account { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } = [];

    }
}
