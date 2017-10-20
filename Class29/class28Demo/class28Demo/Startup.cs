﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using class28Demo.Models;
using Microsoft.AspNetCore.Identity;
using class28Demo.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace class28Demo
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

       public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie("MyCookieLogin", options =>
                options.AccessDeniedPath = new PathString("/Account/Forbidden/"));


            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin Only", policy => policy.RequireRole("Administrator"));
                options.AddPolicy("MinimumAge", policy => policy.Requirements.Add(new MinimumAgeRequirement()));

            }
            );

            services.AddSingleton<IAuthorizationHandler, Is18>();
           

            services.AddMvc();

            services.AddDbContext<class28DemoContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("class28DemoContext")));

            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("class28DemoContext")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
                   
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
