using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ASP.Net_Core_MVC_CRUD_App.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
