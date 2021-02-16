using Microsoft.AspNetCore.Identity;
using System;

namespace ManagementStudent.Entities.Models
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        
    }
}
