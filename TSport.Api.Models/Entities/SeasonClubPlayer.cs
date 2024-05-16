using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSport.Api.Models.Entities
{
    public class SeasonClubPlayer
    {
        public int SeasonId { get; set; }

        public int ClubId { get; set; }

        public int PlayerId { get; set; }

        //Navigators
        public virtual Season Season { get; set; } = null!;

        public virtual Club Club { get; set; } = null!;

        public virtual Player Player { get; set; } = null!;
    }
}