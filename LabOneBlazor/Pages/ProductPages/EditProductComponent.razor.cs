using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;

namespace LabOneBlazor.Pages.ProductPages
{
    public partial class EditProductComponent
    {

        // manage navigation between component 
        // built in service already registered
        [Inject]
        public NavigationManager navigationManager{ get; set; }

        [Inject]
        public IService<Product> ProdSer { get; set; }

        [Inject]
        public IService<Categroy> catSer { get; set; }

        public List<Categroy> categories { get; set; }
        [Parameter]
        public int id { get; set; }
        public Product Product { get; set; }

        protected override void OnInitialized()
        {
            categories = catSer.GetAll();
            Product = ProdSer.GetById(id);
            base.OnInitialized();
        }

        void Save()
        {
            Console.WriteLine("Data Saved");
            navigationManager.NavigateTo("/prods");
        }

    }
}
