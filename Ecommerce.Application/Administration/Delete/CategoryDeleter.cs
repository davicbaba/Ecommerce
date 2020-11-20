using Ecommerce.Domain.DomainServices.Administrator.Find;
using Ecommerce.Domain.Events;
using Ecommerce.Domain.Models.Administration.Category;
using Ecommerce.Domain.Repositories.Administrator;
using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Administration.Delete
{
    public class CategoryDeleter
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IEventBus _eventBus;
        private readonly SharedCategoryFinder _categoryFinder;

        public CategoryDeleter(ICategoryRepository categoryRepository,
                               IEventBus eventBus,
                               SharedCategoryFinder categoryFinder)
        {
            _categoryRepository = categoryRepository;
            _eventBus = eventBus;
            _categoryFinder = categoryFinder;
        }

        public async Task Execute(CategoryId id, CategoryDescription description)
        {
            Category category = await _categoryFinder.Execute(id);

            await _categoryRepository.DeleteAsync(category).ConfigureAwait(false);

            await _categoryRepository.SaveChangesAsync().ConfigureAwait(false);

            await _eventBus.Publish(category.PullDomainEvents());
        }
    }
}
