using Ecommerce.Domain.Events;
using Ecommerce.Domain.Models.Administration.Category;
using Ecommerce.Domain.Repositories.Administrator;
using Ecommerce.Domain.ValueObject.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Administration.Create
{
    public class CategoryCreator
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IEventBus _eventBus;
        public CategoryCreator(ICategoryRepository categoryRepository, IEventBus eventBus)
        {
            _categoryRepository = categoryRepository;
            _eventBus = eventBus;
        }

        public async Task Execute(CategoryId id, CategoryDescription description)
        {
            Category category = new Category(id, description);

            await _categoryRepository.SaveAsync(category).ConfigureAwait(false);

            await _categoryRepository.SaveChangesAsync();

            await _eventBus.Publish(category.PullDomainEvents());
        }
    }
}
