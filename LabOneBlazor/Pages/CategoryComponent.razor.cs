using LabOneBlazor.Models;

namespace LabOneBlazor.Pages
{
    public partial class CategoryComponent
    {
        public int CatId { get; set; }
        public List<Categroy> Categories{ get; set; }
        public List<Product> Products { get; set; }
        public List<Product> OurProds { get; set; }

        public CategoryComponent()
        {
            Categories = new List<Categroy>
            {
                new Categroy { Id = 10, Name = "Electronics", Products = new List<Product>() },
                new Categroy { Id = 20, Name = "Clothing", Products = new List<Product>() },
                new Categroy { Id = 30, Name = "Books", Products = new List<Product>() },
                new Categroy { Id = 40, Name = "Home Appliances", Products = new List<Product>() },
                new Categroy { Id = 50, Name = "Toys", Products = new List<Product>() }
            };

            // Step 2: Create products
            OurProds = new List<Product>
            {
                // Electronics
                new Product { Id = 1, Name = "Smartphone", Price = 299.99m, ImageUrl = "/images/1.jpg", CategoryId = 10 },
                new Product { Id = 2, Name = "Laptop", Price = 899.99m, ImageUrl = "/images/2.jpg", CategoryId = 10 },
                new Product { Id = 3, Name = "Tablet", Price = 399.99m, ImageUrl = "/images/3.jpg", CategoryId = 10 },
                new Product { Id = 4, Name = "Headphones", Price = 59.99m, ImageUrl = "/images/4.jpg", CategoryId = 10 },

                // Clothing
                new Product { Id = 5, Name = "T-Shirt", Price = 19.99m, ImageUrl = "/images/1.jpg", CategoryId = 20 },
                new Product { Id = 6, Name = "Jeans", Price = 49.99m, ImageUrl = "/images/2.jpg", CategoryId = 20 },
                new Product { Id = 7, Name = "Jacket", Price = 89.99m, ImageUrl = "/images/3.jpg", CategoryId = 20 },

                // Books
                new Product { Id = 8, Name = "C# Programming", Price = 29.99m, ImageUrl = "/images/1.jpg", CategoryId = 30 },
                new Product { Id = 9, Name = "ASP.NET Core Guide", Price = 39.99m, ImageUrl = "/images/2.jpg", CategoryId = 30 },
                new Product { Id = 10, Name = "Clean Code", Price = 34.99m, ImageUrl = "/images/3.jpg", CategoryId = 30 },

                // Home Appliances
                new Product { Id = 11, Name = "Microwave", Price = 120.00m, ImageUrl = "/images/1.jpg", CategoryId = 40 },
                new Product { Id = 12, Name = "Refrigerator", Price = 499.99m, ImageUrl = "/images/2.jpg", CategoryId = 40 },
                new Product { Id = 13, Name = "Air Conditioner", Price = 699.99m, ImageUrl = "/images/3.jpg", CategoryId = 40 },

                // Toys
                new Product { Id = 14, Name = "Toy Car", Price = 15.99m, ImageUrl = "/images/1.jpg", CategoryId = 50 },
                new Product { Id = 15, Name = "Doll", Price = 12.99m, ImageUrl = "/images/2.jpg", CategoryId = 50 },
                new Product { Id = 16, Name = "Puzzle", Price = 9.99m, ImageUrl = "/images/3.jpg", CategoryId = 50 }

            };

            //// Step 3: Assign products to categories
            //foreach (var category in Categories)
            //{
            //    category.Products = Products.Where(p => p.CategoryId == category.Id).ToList();
            //}
        }

        void LoadProds()
        {
            Products = OurProds.Where(prod => prod.CategoryId == CatId).ToList();
        }




    }
}
