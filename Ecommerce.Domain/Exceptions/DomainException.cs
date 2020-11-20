using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Exceptions
{
    public abstract class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {

        }

        public abstract string GetErrorCode();

    }
}
