using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Category
{
    public record CategoryDescription
    {

        public string Name { get; }
        public string Description { get; set; }

        public CategoryDescription(string name, string description)
        {
            Name = name;
            Description = description;
        }

        protected CategoryDescription()
        {
        }
    }
}
