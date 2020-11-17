using Ecommerce.Domain.Models.Base;
using Ecommerce.Domain.ValueObject.Products.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models.Products
{
    public class Product : RootEntity
    {
        public ProductDescription Description;
        public ProductId ProductId;

        public Product(ProductId productId, ProductDescription description)
        {
            Description = description;
            ProductId = productId;
        }


    }
}
