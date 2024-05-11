using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSport.Api.BusinessLogic.Interfaces;
using TSport.Api.DataAccess.Interfaces;
using TSport.Api.Models.Entities;
using TSport.Api.Shared.DTOs.Products;

namespace TSport.Api.BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<GetProductDto>> GetProducts()
        {
            return (await _unitOfWork.Repository<Product>().GetAllAsync()).Adapt<List<GetProductDto>>();
        }
    }
}
