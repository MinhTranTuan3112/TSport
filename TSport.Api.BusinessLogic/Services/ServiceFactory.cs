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
        private readonly Lazy<IProductService> _productService;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceFactory(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _productService = new Lazy<IProductService>(() => new ProductService(_unitOfWork));
        }

        public IProductService GetProductService() => _productService.Value;
    }
}
