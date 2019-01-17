using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using WebSIS.DA;
using WebSIS.DA.Context;
using WebSIS.DA.Repositories;
using WebSIS.DA.Repositories.Interfaces;

namespace WebSIS
{
    public class Startup
    {
        IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(option=>option.SerializerSettings.ContractResolver=new CamelCasePropertyNamesContractResolver());
            services.AddCors();
            services.AddAutoMapper();
            services.AddDbContext<SISContext>(option => option.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            DependencyInjection(services);
        }
        void DependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentCategoryRepository, DepartmentCategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
            app.UseMvc();


        }
    }
}
