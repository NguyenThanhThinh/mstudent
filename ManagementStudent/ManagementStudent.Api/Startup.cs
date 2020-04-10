using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementStudent.Data;
using ManagementStudent.Entities.Models;
using ManagementStudent.Services.Users;
using ManagementStudent.Utilities.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace ManagementStudent.Api
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
			services.AddDbContext<ManagementStudentDbContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));

			services.AddIdentity<User, Role>()
				.AddEntityFrameworkStores<ManagementStudentDbContext>()
				.AddDefaultTokenProviders();

			services.AddTransient<UserManager<User>, UserManager<User>>();
			services.AddTransient<SignInManager<User>, SignInManager<User>>();
			services.AddTransient<RoleManager<Role>, RoleManager<Role>>();
			services.AddTransient<IUserService, UserService>();
			//Register the Swagger generator, defining 1 or more Swagger documents
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Management Student", Version = "v1" });
			});
			services.AddControllers();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			// Enable middleware to serve generated Swagger as a JSON endpoint.
			app.UseSwagger();

			//Enable middleware to serve swagger - ui(HTML, JS, CSS, etc.),
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Management Student V1");
			});
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
