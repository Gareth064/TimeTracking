using RESTFulSense.Clients;
using System;
using TimeTracking.UI.Blazor.Models.Configurations;

namespace TimeTracking.UI.Blazor;
public class Startup
{
    public Startup(IConfiguration configuration) =>
            Configuration = configuration;

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddServerSideBlazor();
        services.AddAntDesign();
        AddHttpClient(services);
        AddRootDirectory(services);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapBlazorHub();
            endpoints.MapFallbackToPage("/_Host");
        });
    }

    private static void AddRootDirectory(IServiceCollection services)
    {
        services.AddRazorPages(options =>
        {
            options.RootDirectory = "/Views/Pages";
        });
    }

    private void AddHttpClient(IServiceCollection services)
    {
        services.AddHttpClient<IRESTFulApiFactoryClient, RESTFulApiFactoryClient>(client =>
        {
            LocalConfigurations localConfigurations = Configuration.Get<LocalConfigurations>();
            string apiUrl = localConfigurations.ApiConfigurations.Url;
            client.BaseAddress = new Uri(apiUrl);
        });
    }
}
