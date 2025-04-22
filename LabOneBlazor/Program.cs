using LabOneBlazor.Services.Implemenation;
using LabOneBlazor.Services.@interface;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace LabOneBlazor;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        //It registers the root component(< App />) of your Blazor application and tells Blazor where to render it in the HTML.
        // routing url to compatible component
        builder.RootComponents.Add<App>("#app");

        // Adds the HeadOutlet component to the <head> section of the page.
        // It looks for the <PageTitle> component in each page and updates the document title accordingly.
        // This is important for search engine optimization (SEO), as it ensures each page has a relevant and dynamic title.
        builder.RootComponents.Add<HeadOutlet>("head::after");



        // Transient => A new instance of the service is created each time it is requested.
        // Scoped  => A new instance of the service is created once per request or component scope. In Blazor, the scope typically lasts for a single navigation or lifetime of a component instance.
        // Singleton => A single instance of the service is created and shared across the entire application.


        builder.Services.AddScoped<IService<Product>, ProductServies>();
        builder.Services.AddScoped<IService<Categroy>, CategoryService>();
        builder.Services.AddScoped<IServiceAsync<Department>, DepartmentService>();
        builder.Services.AddScoped<IServiceAsync<Course>, CourseService>();

        builder.Services.AddScoped(sp => new HttpClient 
        { 
            BaseAddress = new Uri("https://localhost:7221") 
        });

        await builder.Build().RunAsync();
    }
}
