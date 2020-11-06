using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Tienda.Soporte.Infraestructura.Persistence;
using Tienda.Soporte.Domain.Persistence;
using Tienda.Soporte.Infraestructura.Persistence.Repository;
using Tienda.Soporte.Domain.Persistence.Repository;

namespace Tienda.Soporte.Web
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
            services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(
                   Configuration.GetConnectionString("DBConnectionString"),
                   b => b.MigrationsAssembly("Tienda.Soporte.Web")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICitaRepository, CitaRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<ISoporteRepository, SoporteRepository>();
            services.AddScoped<ISoporteProductoRepository, SoporteProductoRepository>();
            services.AddScoped<ITecnicoRepository, TecnicoRepository>();
            services.AddControllers();
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
