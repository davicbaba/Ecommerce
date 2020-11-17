using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Models.Category
{
    public class Category : RootEntity
    {
        public CategoryId Id;
        public CategoryDescription Description;

        public Category(CategoryId id, CategoryDescription description)
        {
            Description = description;
            Id = id;
        }
    }
}
