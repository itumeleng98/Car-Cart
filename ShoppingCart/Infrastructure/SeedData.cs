using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Data
{
        public class SeedData
        {
                public static void SeedDatabase(DataContext context)
                {
                        context.Database.Migrate();

                        if (!context.Products.Any())
                        {
                                Category porsche = new Category { Name = "Porsche", Slug = "porsche" };
                                Category toyota = new Category { Name = "Toyota", Slug = "toyota" };

                                context.Products.AddRange(
                                        new Product
                                        {
                                                Name = "Cayenne",
                                                Slug = "cayenne",
                                                Description = "Cayenne Gts",
                                                Price = 41000.50M,
                                                Category = porsche,
                                                Image = "Cayenne.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Panamera",
                                                Slug = "panamera",
                                                Description = "Turbo",
                                                Price = 47000M,
                                                Category = porsche,
                                                Image = "panamera.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Macan",
                                                Slug = "macan",
                                                Description = "Gts",
                                                Price = 42000.50M,
                                                Category = porsche,
                                                Image = "Macan.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Supra",
                                                Slug = "supra",
                                                Description = "Green supra",
                                                Price = 18000M,
                                                Category = toyota,
                                                Image = "Supra.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Hilux",
                                                Slug = "hilux",
                                                Description = "Gd6",
                                                Price = 15000.39M,
                                                Category = toyota,
                                                Image = "Hilux.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Prado",
                                                Slug = "prado",
                                                Description = "Land cruiser",
                                                Price = 20000.19M,
                                                Category = toyota,
                                                Image = "Prado.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Yaris",
                                                Slug = "Yaris",
                                                Description = "Gr",
                                                Price = 10000.70M,
                                                Category = toyota,
                                                Image = "Yaris.jpg"
                                        },
                                        new Product
                                        {
                                                Name = "Gt3",
                                                Slug = "gt3",
                                                Description = "Coupe",
                                                Price = 300000.60M,
                                                Category = porsche,
                                                Image = "Gt3.jpg"
                                        }
                                );

                                context.SaveChanges();
                        }
                }
        }
}