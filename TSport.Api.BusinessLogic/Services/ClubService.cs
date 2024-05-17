using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.BusinessLogic.Interfaces;
using TSport.Api.DataAccess.Interfaces;
using TSport.Api.Models.Entities;
using TSport.Api.Shared.DTOs.Clubs;

namespace TSport.Api.BusinessLogic.Services
{
    public class ClubService : IClubService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceFactory _serviceFactory;


        public ClubService(IUnitOfWork unitOfWork, IServiceFactory serviceFactory)
        {
            _unitOfWork = unitOfWork;
            _serviceFactory = serviceFactory;
        }

        public async Task<List<GetClubDto>> GetClubs()
        {
            return (await _unitOfWork.Repository<Club>().GetAllAsync()).Adapt<List<GetClubDto>>();
        }

        public async Task<List<GetClubWithPlayersDto>> GetClubWithPlayers()
        {
            return await _unitOfWork.Repository<Club>().Entities
                .ProjectToType<GetClubWithPlayersDto>()
                .ToListAsync();
        }
    }
}
