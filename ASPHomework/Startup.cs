using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Unicode;
using System.Threading.Tasks;
using ASPHomework.Persistence;
using ASPHomework.Persistence.Repositories;
using ASPHomework.Persistence.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ASPHomework
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("DefaultConnection");
            
            
            services.AddDbContext<ApplicationDbContext>(
                options =>
                {
                    
                    if (options.IsConfigured == false)
                    {
                        options.UseSqlServer(connection);
                    }
                }
            );

            services.AddWebEncoders(o =>
            {
                o.TextEncoderSettings = new System.Text.Encodings.Web.TextEncoderSettings(UnicodeRanges.All);
            });
            
            
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddAutoMapper(typeof(Startup));

            services
                .AddTransient<IDestinationRepository, DestinationRepository>()
                .AddTransient<DestinationTermRepository>()
                .AddTransient<OrderRepository>();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "API" });
            });
            
            services.AddMvc(
                options =>
                {
                    options.EnableEndpointRouting = false;
                    options.ModelBindingMessageProvider.SetMissingBindRequiredValueAccessor(s => "xxx");
                    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(s => "xx");
                    options.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => "xx");
                }
                )
                .AddDataAnnotationsLocalization()
                .AddViewLocalization()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}