using LabOneBlazor.Services.@interface;
using System.Net.Http.Json;

namespace LabOneBlazor.Services.Implemenation
{
    public class CourseService : IServiceAsync<Course>
    {
        private readonly HttpClient client;

        //public HttpClient client { get; set; }
        public CourseService(HttpClient _client)
        {
            client = _client;
            //client = new HttpClient();
            //client.  = new Uri("https://localhost:7221");
        }

        public async Task AddAsync(Course Entity)
        {
            await client.PostAsJsonAsync<Course>("/api/Course", Entity);
        }

        public async Task DeleteAsync(int id)
        {
            await client.DeleteAsync($"/api/Course/{id}");
        }

        public async Task EditAsync(int id, Course entity)
        {
            await client.PutAsJsonAsync<Course>($"/api/Course/{id}", entity);
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await client.GetFromJsonAsync<List<Course>>("/api/Course");
        }

        public async Task<Course> GetbyIdAsync(int id)
        {
            return await client.GetFromJsonAsync<Course>($"/api/Course/{id}");
        }
    }
}
