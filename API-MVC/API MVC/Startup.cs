using API_MVC.Configurations;

namespace API_MVC
{
    public class Startup(IConfiguration configuration, IWebHostEnvironment environment)
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllers();
            services.AddDependencyInjection();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();

            using var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();

            app.UseCors(configurePolicy: c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            app.UseHttpsRedirection();

            app.UseEndpoints(configure: end =>
            {
                end.MapDefaultControllerRoute();
                end.MapGet(pattern: "/", handler: () => $"Started");
            });
        }
    }
}
