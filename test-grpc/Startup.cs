using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using test_grpc.Data;
using test_grpc.Data.Repository;
using test_grpc.Services;

namespace test_grpc
{
    public class Startup
    {
        private readonly IConfiguration config;

        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => {
                options.UseSqlite(config.GetConnectionString("Default"));
            });
            services.AddTransient<IEmployeeRepo, EmployeeRepo>();
            services.AddGrpc();
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(core => {
                core.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
            });
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<GreeterService>();
                endpoints.MapGrpcService<EmployeeService>();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}
