using Ecommerce.Domain.Models.Administration.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Repositories.Administrator
{
    public interface ICategoryRepository
    {
        Task SaveAsync(Category category);

        Task<Category> GetAsync(string id);

        Task SaveChangesAsync();

        Task DeleteAsync(Category category);
    }
}
