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
    [Table("Club")]
    public class Club : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Code { get; set; }

        public required string Name { get; set; }

        public required string LogoUrl { get; set; }

        //Navigators

        public virtual ICollection<Player> Players { get; set; } = [];

        public virtual ICollection<Season> Seasons { get; set; } = [];
    }
}
