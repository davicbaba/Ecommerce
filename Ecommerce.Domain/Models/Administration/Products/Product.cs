using Ecommerce.Domain.Models.Base;
using Ecommerce.Domain.ValueObject.Products.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models.Administration.Products
{
    public class Product : AggregateRoot
    {
        public ProductDescription Description;
        public ProductId Id;

        public Product(ProductId id, ProductDescription description)
        {
            Description = description;
            Id = id;
        }

        protected Product()
        {

        }
    }
}
