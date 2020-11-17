using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Products.Product
{
    public record ProductId 
    {
        public string Id { get;}

        public ProductId(string id)
        {
            Id = id;
        }
    }
}
