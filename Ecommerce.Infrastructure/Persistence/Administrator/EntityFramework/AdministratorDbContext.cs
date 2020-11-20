using Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework.Mappings.CategoryMap;
using Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework.Mappings.ProductCategoryMap;
using Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework.Mappings.ProductsMap;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework
{
    public class AdministratorDbContext : DbContext
    {
        public AdministratorDbContext(DbContextOptions<AdministratorDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
