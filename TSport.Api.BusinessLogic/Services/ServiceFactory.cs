using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.BusinessLogic.Interfaces;
using TSport.Api.DataAccess.Interfaces;

namespace TSport.Api.BusinessLogic.Services
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly Lazy<IClubService> _clubService;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceFactory(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _clubService = new Lazy<IClubService>(() => new ClubService(_unitOfWork, this));
        }

        public IClubService GetClubService() => _clubService.Value;

    }
}
