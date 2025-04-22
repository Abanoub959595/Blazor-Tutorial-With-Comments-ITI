using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LabOneBlazor.Pages.CoursePages
{
    public partial class UpdateCourseComponent
    {
        [Parameter]
        public int id { get; set; }

        public Course course { get; set; }
        [Inject]
        public IServiceAsync<Course> crsSer{ get; set; }

        public UpdateCourseComponent()
        {
            
        }

        protected override async Task OnInitializedAsync()
        {
            course = await crsSer.GetbyIdAsync(id);
            Console.WriteLine(course);
            //return 
            base.OnInitializedAsync();
        }

        async Task HandleValidSubmit()
        {
            await crsSer.EditAsync(id, course);
        }

    }
}
