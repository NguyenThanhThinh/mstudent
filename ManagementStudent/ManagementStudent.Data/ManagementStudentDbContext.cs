using ManagementStudent.Data.Configurations;
using ManagementStudent.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementStudent.Data
{
	public class ManagementStudentDbContext : DbContext
	{
		public ManagementStudentDbContext(DbContextOptions options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new StudentConfigurations());
		}

		public DbSet<Student> Students { get; set; }
	}
}
