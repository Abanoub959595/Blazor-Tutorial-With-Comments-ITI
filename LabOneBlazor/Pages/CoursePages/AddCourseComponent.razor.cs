using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace LabOneBlazor.Pages.CoursePages
{
    public partial class AddCourseComponent
    {
        [Inject]
        public IServiceAsync<Course> crsSer{ get; set; }

        [Inject]
        public NavigationManager navigationManager { get; set; }

        public Course Course { get; set; } = new Course();
        protected override async Task OnInitializedAsync()
        {

            base.OnInitializedAsync();
        }

        async Task Save()
        {
            await crsSer.AddAsync(Course);
            navigationManager.NavigateTo("/crs");
        }

    }
}
