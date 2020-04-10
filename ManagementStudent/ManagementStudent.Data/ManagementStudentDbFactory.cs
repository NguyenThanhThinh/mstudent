using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ManagementStudent.Data
{
	public class ManagementStudentDbFactory: IDesignTimeDbContextFactory<ManagementStudentDbContext>
    {
        public ManagementStudentDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ManagementStudentDb");

            var optionsBuilder = new DbContextOptionsBuilder<ManagementStudentDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ManagementStudentDbContext(optionsBuilder.Options);
        }
    }
}
