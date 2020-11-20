using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Category
{
    public record CategoryId
    {
        public string Value { get; }

        public CategoryId(string value)
        {
            Value = value;
        }

        protected CategoryId()
        {
        }
    }
}
