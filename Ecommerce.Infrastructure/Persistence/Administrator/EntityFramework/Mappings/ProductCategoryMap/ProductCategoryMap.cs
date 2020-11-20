using Ecommerce.Domain.Models.Administration.Administration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework.Mappings.ProductCategoryMap
{
    public class ProductCategoryMap : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => x.tempid);

            builder.OwnsOne(m => m.Id, a =>
            {
                a.Property(p => p.ProductId).HasMaxLength(100).HasColumnName("ProductId");
                a.Property(p => p.CategoryId).HasMaxLength(100).HasColumnName("CategoryId");
            });

            builder.OwnsOne(m => m.Order, a =>
            {
                a.Property(p => p.Value).HasColumnName("Order");
            });

         
        }
    }
}
