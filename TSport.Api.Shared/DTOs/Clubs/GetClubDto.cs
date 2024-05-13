using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Shared.DTOs.Clubs
{
    public record GetClubDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }
    }
}
