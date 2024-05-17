using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Shared.DTOs.Players
{
    public class GetPlayerDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public int ClubId { get; set; }
    }
}
