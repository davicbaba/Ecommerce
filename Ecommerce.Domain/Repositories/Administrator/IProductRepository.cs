using Ecommerce.Domain.Models.Administration.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Repositories.Administrator
{
    public interface IProductRepository
    {
        Task SaveAsync(List<Product> products);

        Task<Product> GetAsync(string id);

        Task SaveChangesAsync();
    }
}
