using Consul;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Tavisca.StudentAdmissionSystem.Adapter;
using Tavisca.StudentAdmissionSystem.Adapter.Database;
using Tavisca.StudentAdmissionSystem.Adapter.Model;
using Tavisca.StudentAdmissionSystem.ConsulServices;
using Tavisca.StudentAdmissionSystem.ConsulServices.Model;
using Tavisca.StudentAdmissionSystem.Contract.Model;

namespace Tavisca.StudentAdmissionSystem.Web
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
            services.Configure<ConsulConfigurationException>(Configuration.GetSection("consulConfig"));
            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                var address = Configuration["consulConfig:address"];
                consulConfig.Address = new Uri(address);
            }));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IStudentAdmissionSystem, Admission>();
            services.AddSingleton<IConsulServices, ConsulAccess>();
            services.AddSingleton<IStudentAdmission, StudentAdmissionAdapter>();
            services.AddSingleton<IDatabase, FileSystem>(); 
           //services.AddSingleton<Tavisca.Platform.Common.Configurations.IConfigurationProvider, Tavisca.Common.Plugins.Configuration.ConfigurationProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            } 
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

