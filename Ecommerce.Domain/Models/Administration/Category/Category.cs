using Ecommerce.Domain.Events.Category;
using Ecommerce.Domain.Models.Base;
using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models.Administration.Category
{
    public class Category : AggregateRoot
    {
        public CategoryDescription Description { get; set; }

        public CategoryId Id { get; set; }

        public Category(CategoryId id, CategoryDescription description)
        {
            Description = description;
            Id = id;

            CategoryCreated categoryCreated = new(id.Value, description.Name, description.Description);

            base.Record(categoryCreated);
        }

        protected Category()
        {

        }
    }
}
