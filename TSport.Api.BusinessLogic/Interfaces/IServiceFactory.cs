using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.BusinessLogic.Interfaces
{
    public interface IServiceFactory
    {
        IProductService GetProductService();
    }
}
