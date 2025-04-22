using LabOneBlazor.Services.@interface;

namespace LabOneBlazor.Services.Implemenation
{
    public class CategoryService : IService<Categroy>
    {
        List<Categroy> Categories;
        public CategoryService()
        {
            Categories = new List<Categroy>()
            {
                new Categroy { Id = 10, Name = "Electronics", Products = new List<Product>() },
                new Categroy { Id = 20, Name = "Clothing", Products = new List<Product>() },
                new Categroy { Id = 30, Name = "Books", Products = new List<Product>() },
                new Categroy { Id = 40, Name = "Home Appliances", Products = new List<Product>() },
                new Categroy { Id = 50, Name = "Toys", Products = new List<Product>() }
            };
        }
        public List<Categroy> GetAll()
        {
            return Categories;
        }

        public Categroy GetById(int id)
        {
            return Categories.FirstOrDefault(cat => cat.Id == id);
        }
    }
}
