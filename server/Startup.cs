using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using server.DataAccesses.Base;
using server.DataTransfers;

namespace server {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices (IServiceCollection services) {
            Mapper.Initialize (config => config.AddProfile<MappingProfile> ());
            services.AddRouting (options => options.LowercaseUrls = true);
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2);
            services.AddSwaggerDocument (config => {
                config.PostProcess = document => {
                    document.Info.Version = "v1";
                    document.Info.Title = "ASP DOTNET demo";
                    document.Info.Description = "Create RESTful API Demo for .NET Project";
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
                RealmDatabase.Config.ShouldDeleteIfMigrationNeeded = true;

            }
            app.UseSwagger ();
            app.UseSwaggerUi3 (config => {
                config.WithCredentials = true;
            });
            app.UseMvc ();
        }
    }
}