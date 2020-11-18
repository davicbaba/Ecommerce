﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Events.ProductCategory
{
    public record ProductCategoryCreated : IDomainEvent
    {
        public string ProductId { get; }
        public string CategoryId { get; }
        public int Order { get; }

        public ProductCategoryCreated(string productId, string categoryId, int order)
        {
            ProductId = productId;
            CategoryId = categoryId;
            Order = order;
        }

        public string FullQualifiedEventName()
        {
            return "administrator.category.1.event.product.category.created";
        }
    }
}
