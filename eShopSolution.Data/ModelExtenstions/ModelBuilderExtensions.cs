using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.ModelExtenstions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                  new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSoultion" },
                    new AppConfig() { Key = "HomeKeyWord", Value = "This is keyword of eShopSoultion" },
                      new AppConfig() { Key = "HomeDescription", Value = "This is Description page of eShopSoultion" }
                      );
            modelBuilder.Entity<Language>().HasData(
                 new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                 new Language() { Id = "en-Us", Name = "English", IsDefault = false }
                );



            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParenrId = null,
                    SortOrder = 1,
                    Status = Enums.Status.Active
                }
                   );


            modelBuilder.Entity<CategoryTranslation>().HasData(

                          new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo Nam", LanguageId = "vi-VN", SeoAlias = "ao-nam", SeoDescription = "Sản Phẩm áo Thời TRang Nam", SeoTitle = "Sản Phẩm áo Thời TRang Nam" },
                          new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" }

            ); ;

            modelBuilder.Entity<ProductTranslation>().HasData(


                          new ProductTranslation() { Id = 1, ProductId = 1, Name = "Áo Nam Sơ Mi", LanguageId = "vi-VN", SeoAlias = "ao-nam-so-mi", SeoDescription = "Sản Phẩm áo Thời TRang Nam so mi", SeoTitle = "Sản Phẩm áo Thời TRang Nam", Details = "Mô Tả Sản Phẩm", Description = "" },
                          new ProductTranslation() { Id = 2, ProductId = 1, Name = "Men Shirt", LanguageId = "en-US", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men", Details = "Description of product", Description = "" }

                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                 new ProductInCategory() { ProductId = 1, CategoryId = 1 });
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginaPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                }

                   );
        }
    }
}


