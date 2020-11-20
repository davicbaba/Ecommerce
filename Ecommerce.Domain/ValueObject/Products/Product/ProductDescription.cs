using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Products.Product
{
    public record ProductDescription
    {

        public ProductDescription(string name, string description, string largeDescription)
        {
            Name = name;
            Description = description;
            LargeDescription = largeDescription;
        }
        protected ProductDescription()
        {
        }
        public string Name { get; }
        public string Description { get;}
        public string LargeDescription { get; }


    }
}
