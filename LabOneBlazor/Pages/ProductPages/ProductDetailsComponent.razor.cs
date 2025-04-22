using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;

namespace LabOneBlazor.Pages.ProductPages
{
    public partial class ProductDetailsComponent
    {
        public bool IsLoading { get; set; } = true;
        // ✅ Follows Dependency Inversion Principle (DIP):
        //    - High-level modules (like this component) depend on abstractions, not concrete implementations.
        //    - We don't create the service manually — we ask for it via dependency injection.

        // the dependency injection (DI) system fulfills injected dependencies
        // before the component’s lifecycle methods like OnInitialized() or OnInitializedAsync() are called.
        [Inject]
        public IService<Product> ProdSer { get; set; }
        [Parameter]
        public int id { get; set; }
        public Product Product { get; set; }

        protected async override Task OnInitializedAsync()
        {
            try
            {
                await Task.Delay(3000);
                Product = ProdSer.GetById(id);

            }
            catch
            {
                Product = null;
            }
            finally
            {
                IsLoading = false;
            }
            base.OnInitializedAsync();
        }


    }
}
