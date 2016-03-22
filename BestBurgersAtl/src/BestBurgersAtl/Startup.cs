using System;
using System.Linq;
using Autofac;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Autofac.Extensions.DependencyInjection;
using BestBurgersAtl.Resources;
using BestBurgersAtl.Resources.DA;
using Newtonsoft.Json.Serialization;

namespace BestBurgersAtl
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver =
                    new CamelCasePropertyNamesContractResolver();
            }); ;

            // Add our repository type
            // Create the Autofac container builder.
            //var builder = new ContainerBuilder();
            //// Add any Autofac modules or registrations.
            //builder.RegisterModule(new AutofacModule());
            //// Populate the services.
            //builder.Populate(services);
            //// Build the container.
            //var container = builder.Build();
            //// Resolve and return the service provider.
            ////TODO: Fix Di either using autoFac or MVC 6
            //ServiceDescriptor isServiceAdded = services.FirstOrDefault(s => s.ServiceType == typeof(IPostRepository));
            //var x = 2;
            //return container.Resolve<IServiceProvider>();

            services.AddSingleton(typeof(IPostRepository), typeof(PostRepository));

            //var isServiceAdded = services.FirstOrDefault(s => s.ServiceType == typeof (IPostRepository));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseIISPlatformHandler();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(config =>
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Home" }
            ));
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
