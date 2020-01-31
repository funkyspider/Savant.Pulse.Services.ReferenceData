using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Savant.Pulse.DataAccessLayer.ReferenceData;


using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Savant.Pulse.DataAccessLayer.ReferenceData.Models;
using Savant.Pulse.WebApi.ReferenceData.Services;


namespace Savant.Pulse.Services.ReferenceData
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddOData();


            services.AddDbContext<PulseReferenceContext>();
            services.AddLogging(config =>
            {
                config.AddConsole();
                config.SetMinimumLevel(LogLevel.Information);
            });
            services.AddControllers();

            services.AddTransient<IReferenceDataService, ReferenceDataService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            var builder = new ODataConventionModelBuilder(app.ApplicationServices);
            ConfigureOdataEntities(builder);

            app.UseMvc(routeBuilder =>
            {
                // and this line to enable OData query option, for example $filter
                routeBuilder.Select().Expand().Filter().OrderBy().MaxTop(100).Count();

                routeBuilder.MapODataServiceRoute("ODataRoute", "odata", builder.GetEdmModel());

                // uncomment the following line to Work-around for #1175 in beta1
                routeBuilder.EnableDependencyInjection();
            });

            //            app.UseHttpsRedirection();
            //            app.UseRouting();
            //            app.UseAuthorization();
            //            app.UseEndpoints(endpoints =>
            //            {
            //                endpoints.MapControllers();
            //            });
        }

        private static void ConfigureOdataEntities(ODataConventionModelBuilder builder)
        {
            builder.EntitySet<Siteprm>("Siteprm");
            builder.EntitySet<Abocon>("Abocon");
            builder.EntitySet<Abotrn>("Abotrn");
            builder.EntitySet<Addrclen>("Addrclen");

        }
    }
}
