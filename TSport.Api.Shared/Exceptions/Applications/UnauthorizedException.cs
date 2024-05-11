using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSport.Api.Shared.Exceptions.Applications
{
    public class UnauthorizedException : ApplicationException
    {
        public UnauthorizedException(string message) : base (message)
        {
            
        }
    }
}
