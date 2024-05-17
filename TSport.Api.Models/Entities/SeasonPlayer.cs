using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    [Table("SeasonPlayer")]
    public class SeasonPlayer : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SeasonId { get; set; }

        public int PlayerId { get; set; }

        //Navigators
        public virtual Season Season { get; set; } = null!;

        public virtual Player Player { get; set; } = null!;
    }
}