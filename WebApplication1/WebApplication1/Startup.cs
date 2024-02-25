using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace WebApplication1
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		//	public void ConfigureServices(IServiceCollection services)
		//	{
		//		services.AddAuthentication(options =>
		//		{
		//			options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
		//			options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
		//			options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
		//		})
		//.AddCookie()
		//.AddGoogle(options =>
		//{
		//	options.ClientId = "YOUR_GOOGLE_CLIENT_ID";
		//	options.ClientSecret = "YOUR_GOOGLE_CLIENT_SECRET";
		//});

		//		services.AddControllersWithViews();

		//		services.AddSession();

		//		services.AddMvc(config=>
		//		{
		//               var policy = new AuthorizationPolicyBuilder()
		//							.RequireAuthenticatedUser()
		//							.Build();
		//               config.Filters.Add(new AuthorizeFilter(policy));
		//           }
		//		);
		//		services.AddMvc();
		//		services.AddAuthentication(
		//			CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x=>
		//			{
		//				x.LoginPath = "/Login/Index";
		//			}
		//			);

		//	}
		//public void ConfigureServices(IServiceCollection services)
		//{
		//	// OAuth 2.0 kimlik doðrulama iþlemi için Google seçeneklerini yapýlandýr
		//	services.AddAuthentication(options =>
		//	{
		//		options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
		//		options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
		//		options.DefaultChallengeScheme = "External"; // "External" olarak ayarla
		//	})
		//	.AddCookie(options =>
		//	{
		//		options.LoginPath = "/Login/Index";
		//	})
		//	.AddGoogle("External", options =>
		//	{
		//		options.ClientId = Configuration["GoogleAuth:client_id"];
		//		options.ClientSecret = Configuration["GoogleAuth:client_secret"];
		//          });

		//          // MVC ve diðer hizmetler
		//          services.AddControllersWithViews();

		//	services.AddSession();

		//	services.AddMvc(config =>
		//	{
		//		var policy = new AuthorizationPolicyBuilder()
		//			.RequireAuthenticatedUser()
		//			.Build();
		//		config.Filters.Add(new AuthorizeFilter(policy));
		//	});
		//}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();

			services.AddSession();

			services.AddMvc(config =>
			{
				var policy = new AuthorizationPolicyBuilder()
								.RequireAuthenticatedUser()
								.Build();
				config.Filters.Add(new AuthorizeFilter(policy));
			}
			);
			services.AddMvc();
			services.AddAuthentication(
				CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
				{
					x.LoginPath = "/Login/Index";
				}
				);

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
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
			app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");
			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseAuthentication();

			app.UseSession();
			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
