using ASPCOREFilterAndMiddleWareConceptsWebApp.Models;

namespace ASPCOREFilterAndMiddleWareConceptsWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddScoped<CustomAsyncActionFilter>();

            // Add services to the container.
            builder.Services.AddControllersWithViews(
                options => {
                    options.Filters.Add(new ServiceExceptionInterceptor());
                    //by the type
                    //options.Filters.Add(new CustomActionFilter());
                    //an instance 
                    options.Filters.Add<CustomAsyncActionFilter>();
                }
                );

            var app = builder.Build();


            //Define a GET endpoint;
            app.MapGet("/", () => "Hello World!");
            //Define a GET endpoint with parameter
            app.MapGet("/greet/{name}", (string name) => $"Hello,{name}");
            //Define a GET endpoint with two int parameters
            app.MapGet("/sum/{a:int}/{b:int}", (int a, int b) => $"Sum is {a + b}");
            //Using Query String in the lambda function
            app.MapGet("/calculate", (int x, int y) => $"the result of {x}+{y} is {x + y}");
            //Define a GET endpoint wants to return structured data as JSON
            app.MapGet("/user", () => new { Id = 1, Name = "Harshit sharma", Age = 22 });



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}