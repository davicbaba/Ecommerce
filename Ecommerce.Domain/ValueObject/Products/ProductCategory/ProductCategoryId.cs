using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Products.ProductCategory
{
    public record ProductCategoryId
    {
        public string ProductId { get; }
        public string CategoryId { get; }

        public ProductCategoryId(string productId, string categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }


    }
}
