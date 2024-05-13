using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Shared.DTOs.Clubs;

namespace TSport.Api.BusinessLogic.Interfaces
{
    public interface IClubService
    {
        Task<List<GetClubDto>> GetClubs();
    }
}
