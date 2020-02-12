using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
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

            // any guid
            var role_id = new Guid("69AAEDE1-57BB-4A90-9AC6-05EAF1999FEE");
           var ADMIN_ID = new Guid("F7C0ED32-6CB6-40A1-B708-A4C9287BA577");
            // any guid, but nothing is against to use the same one
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = role_id,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Admin Role"
            }); ;

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "nguyendanhngocndn@gmail.com",
                NormalizedEmail = "nguyendanhngocndn@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456789a"),
                SecurityStamp = string.Empty,
                FirstName = "Ngoc",
                LastName = "Nguyen Danh",
                Dob = DateTime.Now
            }) ; 

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = role_id,
                UserId = ADMIN_ID
            });


        }


    }
}


