using LabOneBlazor.Services.@interface;
using System.Net.Http.Json;

namespace LabOneBlazor.Services.Implemenation
{
    public class DepartmentService : IServiceAsync<Department>
    {
        HttpClient client;
        public DepartmentService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7059");
        }

        public Task AddAsync(Department Entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(int id,Department entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAllAsync()
        {
            //List<Department> res = await client.GetFromJsonAsync<List<Department>>("/api/Department");
            //return res;

            try
            {
                var res = await client.GetFromJsonAsync<List<Department>>("/api/Department");
                return res ?? new List<Department>();
            }
            catch (HttpRequestException ex)
            {
                // Log the error, show alert, etc.
                Console.WriteLine($"Request error: {ex.Message}");
                return new List<Department>();
            }

        }

        public Task<Department> GetbyIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
