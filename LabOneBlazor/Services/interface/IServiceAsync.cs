namespace LabOneBlazor.Services.@interface
{
    public interface IServiceAsync<T> where T : class
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetbyIdAsync (int id);
        public Task EditAsync (int id,T entity);
        public Task AddAsync(T Entity);
        public Task DeleteAsync (int id);

    }
}


/*
Blazor and Web API Communication - Architecture Overview:

- Blazor acts as a **service consumer** (typically in a B2B – Business to Business – context):
  => It sends HTTP requests to a backend Web API.
  => It expects responses in JSON format.
  => It must be equipped to build requests, serialize data to JSON, and deserialize responses back to C# objects.

- The Web API acts as a **service provider**:
  => It exposes endpoints that accept requests (usually JSON).
  => Internally, it uses C# to process the logic and responds with data serialized to JSON.

Data Flow:
- Web API:
  => Converts C# objects to JSON (Serialization).
- Blazor:
  => Converts received JSON data back into C# objects (Deserialization).

- Any service consumer (like Blazor, mobile apps, or other services) needs the following tools:
  => Ability to construct HTTP requests (e.g., using HttpClient).
  => Mechanism for serialization (C# to JSON).
  => Mechanism for deserialization (JSON to C#).

Comparison with MVC:
- MVC applications are typically **B2C – Business to Consumer**:
  => They combine UI and logic on the server side.
  => The browser interacts directly with the rendered HTML, not with APIs.
  => Data binding, rendering, and validation are processed server-side.

Blazor + Web API = decoupled, reusable, scalable architecture suitable for B2B.
MVC = tightly coupled, fast-to-deploy architecture suitable for traditional B2C apps.
*/