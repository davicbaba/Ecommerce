using Ecommerce.Domain.Models.Administration.Administration;
using Ecommerce.Domain.Models.Administration.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework.Mappings.ProductsMap
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.tempid);

            builder.OwnsOne(m => m.Description, a =>
            {
                a.Property(p => p.Description)
                 .HasMaxLength(300)
                 .IsRequired().HasColumnName("Description");

                a.Property(p => p.LargeDescription)
                 .IsRequired().HasColumnName("LargeDescription");

                a.Property(p => p.Name)
                 .HasMaxLength(100)
                 .IsRequired().HasColumnName("Name");
            });

            builder.OwnsOne(m => m.Id, a =>
            {
                a.Property(p => p.Value)
                 .HasMaxLength(100).HasColumnName("Id");

            });

        }
    }
}
