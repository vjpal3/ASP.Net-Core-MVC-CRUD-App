using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ASP.Net_Core_MVC_CRUD_App.Models;
using Microsoft.AspNetCore.Http;

namespace ASP.Net_Core_MVC_CRUD_App.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }

        public IFormFile Photo { get; set; }
    }
}
