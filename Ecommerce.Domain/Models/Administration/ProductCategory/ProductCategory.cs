using Ecommerce.Domain.Models.Base;
using Ecommerce.Domain.ValueObject.Products.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models.Administration.Administration
{
    public class ProductCategory : AggregateRoot
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
