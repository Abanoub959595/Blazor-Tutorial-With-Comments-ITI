using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;

namespace LabOneBlazor.Pages.CoursePages
{
    public partial class CourseComponent
    {
        [Inject]
        public IServiceAsync<Course> crsSer{ get; set; }
        public CourseComponent()
        {
            
        }

        public List<Course> Courses { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Courses = await crsSer.GetAllAsync();
            //return
            base.OnInitializedAsync();
        }




    }
}
