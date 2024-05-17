using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Shared.DTOs.Players;

namespace TSport.Api.Shared.DTOs.Clubs
{
    public class GetClubWithPlayersDto
    {
        public int Id { get; set; }

        public required string Code { get; set; }

        public required string Name { get; set; }

        public required string LogoUrl { get; set; }

        //Navigators

        public virtual ICollection<GetPlayerDto> Players { get; set; } = [];
    }
}
