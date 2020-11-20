using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Products.Product
{
    public record ProductId 
    {
        public string Value { get;}

        public ProductId(string value)
        {
            Value = value;
        }
        protected ProductId()
        {
        }
    }
}
