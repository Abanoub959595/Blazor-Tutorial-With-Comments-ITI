using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;

namespace LabOneBlazor.Pages.CategoryPages
{
    public partial class CategoryComponent
    {
        [Inject]
        public IService<Categroy> catSer { get; set; }

        public List<Categroy> categories{ get; set; }

        protected override void OnInitialized()
        {
            categories = catSer.GetAll();
            base.OnInitialized();
        }


    }
}
