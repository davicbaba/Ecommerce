using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject.Category
{
    public record CategoryId
    {
        public string Id { get; }

        public CategoryId(string id)
        {
            Id = id;
        }
    }
}
