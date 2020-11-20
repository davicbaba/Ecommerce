using Ecommerce.Domain.Models.Administration.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Repositories.Administrator
{
    public interface IProductCategoryRepository
    {
        Task SaveAsync(List<ProductCategory> productsCategories);

        Task<ProductCategory> GetAsync(string productId, string categoryId);

        Task SaveChangesAsync();
        
    }
}
