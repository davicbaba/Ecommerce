using Ecommerce.Domain.DomainServices.Administrator.Find;
using Ecommerce.Domain.Models.Administration.Category;
using Ecommerce.Domain.Repositories.Administrator;
using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Administration.Find
{
    public class CategoryFinder
    {
        private readonly SharedCategoryFinder _categoryFinder;

        public CategoryFinder(SharedCategoryFinder categoryFinder)
        {
            _categoryFinder = categoryFinder;
        }

        public async Task<Category> Execute(CategoryId id)
        {
            Category category = await _categoryFinder.Execute(id);

            return category;
        }

    }
}
