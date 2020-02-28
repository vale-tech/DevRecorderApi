using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RecorderApi.Models;
using RecorderApi.Services;
using Microsoft.Extensions.Options;

namespace RecorderSimulator
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
            // mongodb            
            services
                .Configure<RecorderDatabaseSettings> (Configuration.GetSection (nameof (RecorderDatabaseSettings)));
            services
                .AddSingleton<IRecorderDatabaseSettings> (sp => sp.GetRequiredService<IOptions<RecorderDatabaseSettings>> ().Value);

            services
                .AddSingleton<SessionService> ()
                .AddSingleton<ScheduleService> ();
            
            services
                .AddControllers().AddXmlSerializerFormatters();

            var myConfig = Configuration.GetSection("ValeTesting");

            Console.WriteLine(myConfig.GetValue<string>("ValeOption"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
