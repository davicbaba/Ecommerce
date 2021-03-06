﻿// <auto-generated />
using Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecommerce.Infrastructure.Persistence.Administrator.EntityFramework
{
    [DbContext(typeof(AdministratorDbContext))]
    [Migration("20201120061328_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ecommerce.Domain.Models.Administration.Administration.ProductCategory", b =>
                {
                    b.Property<string>("tempid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("tempid");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Ecommerce.Domain.Models.Administration.Category.Category", b =>
                {
                    b.Property<string>("tempid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("tempid");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Ecommerce.Domain.Models.Administration.Products.Product", b =>
                {
                    b.Property<string>("tempid")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("tempid");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Ecommerce.Domain.Models.Administration.Administration.ProductCategory", b =>
                {
                    b.OwnsOne("Ecommerce.Domain.ValueObject.Products.ProductCategory.ProductCategoryId", "Id", b1 =>
                        {
                            b1.Property<string>("ProductCategorytempid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("CategoryId")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("CategoryId");

                            b1.Property<string>("ProductId")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("ProductId");

                            b1.HasKey("ProductCategorytempid");

                            b1.ToTable("ProductCategory");

                            b1.WithOwner()
                                .HasForeignKey("ProductCategorytempid");
                        });

                    b.OwnsOne("Ecommerce.Domain.ValueObject.Products.ProductCategory.ProductCategoryOrder", "Order", b1 =>
                        {
                            b1.Property<string>("ProductCategorytempid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("Value")
                                .HasColumnType("int")
                                .HasColumnName("Order");

                            b1.HasKey("ProductCategorytempid");

                            b1.ToTable("ProductCategory");

                            b1.WithOwner()
                                .HasForeignKey("ProductCategorytempid");
                        });

                    b.Navigation("Id");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Ecommerce.Domain.Models.Administration.Category.Category", b =>
                {
                    b.OwnsOne("Ecommerce.Domain.ValueObject.Category.CategoryDescription", "Description", b1 =>
                        {
                            b1.Property<string>("Categorytempid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("nvarchar(300)")
                                .HasColumnName("Description");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Name");

                            b1.HasKey("Categorytempid");

                            b1.ToTable("Category");

                            b1.WithOwner()
                                .HasForeignKey("Categorytempid");
                        });

                    b.OwnsOne("Ecommerce.Domain.ValueObject.Category.CategoryId", "Id", b1 =>
                        {
                            b1.Property<string>("Categorytempid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Value")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Id");

                            b1.HasKey("Categorytempid");

                            b1.ToTable("Category");

                            b1.WithOwner()
                                .HasForeignKey("Categorytempid");
                        });

                    b.Navigation("Description");

                    b.Navigation("Id");
                });

            modelBuilder.Entity("Ecommerce.Domain.Models.Administration.Products.Product", b =>
                {
                    b.OwnsOne("Ecommerce.Domain.ValueObject.Products.Product.ProductDescription", "Description", b1 =>
                        {
                            b1.Property<string>("Producttempid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("nvarchar(300)")
                                .HasColumnName("Description");

                            b1.Property<string>("LargeDescription")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LargeDescription");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Name");

                            b1.HasKey("Producttempid");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("Producttempid");
                        });

                    b.OwnsOne("Ecommerce.Domain.ValueObject.Products.Product.ProductId", "Id", b1 =>
                        {
                            b1.Property<string>("Producttempid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Value")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Id");

                            b1.HasKey("Producttempid");

                            b1.ToTable("Product");

                            b1.WithOwner()
                                .HasForeignKey("Producttempid");
                        });

                    b.Navigation("Description");

                    b.Navigation("Id");
                });
#pragma warning restore 612, 618
        }
    }
}
