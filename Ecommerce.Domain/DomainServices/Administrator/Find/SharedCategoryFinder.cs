using Ecommerce.Domain.Exceptions.Administrator.NotFound;
using Ecommerce.Domain.Models.Administration.Category;
using Ecommerce.Domain.Repositories.Administrator;
using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.DomainServices.Administrator.Find
{
    public class SharedCategoryFinder
    {
        private readonly ICategoryRepository _categoryRepository;

        public SharedCategoryFinder(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> Execute(CategoryId id)
        {
            Category category = await _categoryRepository.GetAsync(id.Value).ConfigureAwait(false);

            if (category == null)
                throw new CategoryNotFoundException(id);

            return category;
        }

    }
}
