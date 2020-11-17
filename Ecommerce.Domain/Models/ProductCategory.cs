using Ecommerce.Domain.Models.Base;
using Ecommerce.Domain.ValueObject.Products.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models
{
    public class ProductCategory : RootEntity
    {
        public ProductCategoryId Id;
        public ProductCategoryOrder Order;
        public ProductCategory(ProductCategoryId id, ProductCategoryOrder order)
        {
            Id = id;
            Order = order;
        }
    }
}
