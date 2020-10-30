using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProjectManagement.Context;
using AgileProjectManagement.Context.Entity;
using AgileProjectManagement.Interfaces;
using AgileProjectManagement.Interfaces.Repository;
using AgileProjectManagement.Interfaces.Service;
using AgileProjectManagement.Repository;
using AgileProjectManagement.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySqlConnector;

namespace AgileProjectManagement
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
            services.AddCors();
            services.AddDbContext<ProjectDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));
            services.AddControllers();
            services.AddTransient<IRepository<Project>, ProjectRepository>();
            services.AddTransient<IProjectService<Project>, ProjectService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            //services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration["ConnectionStrings:Default"]));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
