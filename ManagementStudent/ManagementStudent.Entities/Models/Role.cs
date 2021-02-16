using Microsoft.AspNetCore.Identity;
using System;

namespace ManagementStudent.Entities.Models
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
