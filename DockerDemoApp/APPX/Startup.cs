using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace APPX
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            //services.AddEntityFrameworkNpgsql()
            //           .AddDbContext<ApplicationDbContext>()
            //           .BuildServiceProvider();

            services.AddDbContext<ApplicationDbContext>(options =>

            options.UseNpgsql(Configuration.GetConnectionString("ApplicationDbContext")));

            services.AddIdentity<IdentityUser, IdentityRole>(
                   option => option.Stores.MaxLengthForKeys = 128)
                        .AddEntityFrameworkStores<ApplicationDbContext>()
                        .AddDefaultUI()
                        .AddDefaultTokenProviders();


            services.Configure<ForwardedHeadersOptions>(options =>
            {
                
                options.ForwardLimit = 2;
                options.KnownNetworks.Add(new IPNetwork(IPAddress.Parse("172.17.0.0"),16));
                options.ForwardedHeaders =
                    ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto; 
               
                //options.KnownNetworks.Clear();
               // options.KnownProxies.Clear();


            });

            //app.UseForwardedHeaders(forwardOptions);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

              var forwardingOptions = new ForwardedHeadersOptions()
              {
                  ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto 
                                    
              };
                
              forwardingOptions.KnownNetworks.Add(new IPNetwork(IPAddress.Parse("172.17.0.0"), 16)); //its loopback by default
             // forwardingOptions.KnownProxies.Clear();

              app.UseForwardedHeaders(forwardingOptions);                           


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
