using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig()
                {
                    Key = "HomeTitle",
                    Value = "This is home page"
                },
                new AppConfig()
                {
                    Key = "HomeKeyword",
                    Value = "This is keyword"
                });

            modelBuilder.Entity<Language>().HasData(
                new Language()
                {
                    Id = "vi-VN",
                    Name = "Tiếng Việt",
                    IsDefault = true
                },

                new Language()
                {
                    Id = "en-US",
                    Name = "English",
                    IsDefault = false
                });


            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },

                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active,
                }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
               new CategoryTranslation()
               {
                   Id = 1,
                   CategoryId = 1,
                   Name = "Action",
                   LanguageId = "en-US",
                   SeoAlias = "action-games",
                   SeoDescription = "Action games"
               },

               new CategoryTranslation()
               {
                   Id = 2,
                   CategoryId = 1,
                   Name = "Hành động",
                   LanguageId = "vi-VN",
                   SeoAlias = "hanh-dong",
                   SeoDescription = "Trò chơi hành động"
               },

                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Adventure",
                    LanguageId = "en-US",
                    SeoAlias = "adventure",
                    SeoDescription = "Adventure-games"
                },

                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Phiêu lưu",
                    LanguageId = "vi-VN",
                    SeoAlias = "phieu-luu",
                    SeoDescription = "Trò chơi phiêu lưu"
                }

               );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                });

            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Resident evil 2 remake",
                     LanguageId = "en-US",
                     SeoAlias = "resident-evil-2",
                     SeoDescription = "Resident evil 2 remake",
                     Details = "Description of product",
                     Description = ""
                 },

                 new ProductTranslation()
                 {
                     Id = 2,
                     ProductId = 1,
                     Name = "Resident evil 2 remake",
                     LanguageId = "vi-VN",
                     SeoAlias = "resident-evil-2",
                     SeoDescription = "Resident evil 2 remake",
                     Details = "Mô tả sản phẩm",
                     Description = ""
                 });

            modelBuilder.Entity<ProductInCategory>().HasData(
                 new ProductInCategory()
                 {
                     ProductId = 1,
                     CategoryId = 1,
                 }
                );


            var roleId = new Guid("E684A3C4-DD84-4018-AFF5-FD3ACE5886FA");
            var adminId = new Guid("64CE4F89-8B76-4F12-8FD0-3B4CABA86FC8");

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole()
                {
                    Id = roleId,
                    Name = "Admin",
                    NormalizedName = "admin",
                    Description = "Administrator Role"
                });


            var haser = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser()
                {
                    Id = adminId,
                    UserName = "Admin",
                    NormalizedUserName = "admin",
                    Email = "tienlamict@gmail.com",
                    NormalizedEmail = "tienlamict@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = haser.HashPassword(null, "123abc"),
                    SecurityStamp = string.Empty,
                    FirstName = "Nguyen",
                    LastName = "Tien Lam",
                    DateOfBirth = new DateTime(1992,03,03)
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>()
                {
                    RoleId = roleId,
                    UserId = adminId,
                });
        }
    }
}
