using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Products.ProductCategory
{
    public record ProductCategoryOrder
    {
        public int Order { get; }

        public ProductCategoryOrder(int order)
        {
            Order = order;
        }
    }
}
