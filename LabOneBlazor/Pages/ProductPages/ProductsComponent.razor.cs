using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;

namespace LabOneBlazor.Pages.ProductPages
{
    public partial class ProductsComponent
    {
        [Inject]
        public IService<Product> ProdSer { get; set; }
        public List<Product> Products { get; set; }

        protected override void OnInitialized()
        {
            Products = ProdSer.GetAll();
            base.OnInitialized();
        }


    }
}
