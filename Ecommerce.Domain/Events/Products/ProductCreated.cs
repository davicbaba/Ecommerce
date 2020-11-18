using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Events.Products
{
    public record ProductCreated : IDomainEvent
    {
        public string Name { get; }
        public string Description { get; }
        public string LargeDescription { get; }


        public ProductCreated(string name, string description, string largeDescription)
        {
            Name = name;
            Description = description;
            LargeDescription = largeDescription;
        }


        public string FullQualifiedEventName()
        {
            return "administrator.product.1.event.product.created";
        }
    }
}
