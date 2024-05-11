using Microsoft.AspNetCore.Mvc;
using TSport.Api.BusinessLogic.Interfaces;
using TSport.Api.Shared.DTOs.Products;

namespace TSport.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IServiceFactory _serviceFactory;

        public ProductsController(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }


        [HttpGet]
        public async Task<ActionResult<List<GetProductDto>>> GetProducts()
        {
            return await _serviceFactory.GetProductService().GetProducts();
        }
        
    }
}
