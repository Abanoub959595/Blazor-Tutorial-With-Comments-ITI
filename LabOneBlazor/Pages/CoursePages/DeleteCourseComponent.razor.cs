using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;

namespace LabOneBlazor.Pages.CoursePages
{
    public partial class DeleteCourseComponent
    {
        [Inject]
        public NavigationManager navigationManager { get; set; }
        [Inject]
        public IServiceAsync<Course> crsSer{ get; set; }
        public Course Course { get; set; }
        [Parameter]
        public int Id { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Course = await crsSer.GetbyIdAsync(Id);

            base.OnInitializedAsync();
        }

        async Task Deletcourse()
        {
            await crsSer.DeleteAsync(Id);
            navigationManager.NavigateTo("/crs");
        }



    }
}
