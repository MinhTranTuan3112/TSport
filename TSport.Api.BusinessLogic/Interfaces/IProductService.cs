using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.Shared.DTOs.Products;

namespace TSport.Api.BusinessLogic.Interfaces
{
    public interface IProductService
    {
        Task<List<GetProductDto>> GetProducts();
    }
}
