using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSport.Api.BusinessLogic.Interfaces;
using TSport.Api.Shared.DTOs.Clubs;

namespace TSport.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        private readonly IServiceFactory _serviceFactory;

        public ClubsController(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetClubDto>>> GetClubs()
        {
            return await _serviceFactory.GetClubService().GetClubs();
        }
    }
}
