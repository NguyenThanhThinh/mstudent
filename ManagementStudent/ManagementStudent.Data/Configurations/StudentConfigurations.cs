using ManagementStudent.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementStudent.Data.Configurations
{
	public class StudentConfigurations : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.ToTable("Students");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id).UseIdentityColumn();
		}
	}
}
