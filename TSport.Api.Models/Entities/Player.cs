﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Models.Abstractions;

namespace TSport.Api.Models.Entities
{
    [Table("Player")]
    public class Player : BaseAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required string Code { get; set; }

        public required string Name { get; set; }

        public int ClubId { get; set; }

        //Navigators

        public virtual ICollection<Shirt> Shirts { get; set; } = [];

        public virtual Club Club { get; set; } = null!;

        public virtual ICollection<SeasonPlayer> SeasonPlayers { get; set; } = [];
    }
}
