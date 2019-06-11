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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Restaurante.DAL.Infra;
using Restaurante.DAL;
using Restaurante.BLL.Infra;
using RestauranteApi.UoW.Infra;
using Restaurante.DAL.DataBaseContext;
using Restaurante.BLL;
using RestauranteApi.UoW;
using Newtonsoft.Json.Serialization;

namespace RestauranteApi
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
            //  DB CONTEXT
            services.AddScoped<IRestauranteDbContext, RestauranteDbContext>();

            //  REPOSITORY
            services.AddScoped<ILoginRepository, LoginRepository>();

            //  BLL 
            services.AddScoped<ILoginBLL, LoginBLL>();

            //  UoW
            services.AddScoped<ILoginUoW, LoginUoW>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                // FORMATACAO JSON (PASCAL CASE)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
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

            app.UseCors(builder => builder
                                    .AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials()
                        );

            app.UseMvc();
        }
    }
}
