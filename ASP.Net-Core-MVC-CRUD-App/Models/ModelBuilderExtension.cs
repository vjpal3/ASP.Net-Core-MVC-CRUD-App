using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Core_MVC_CRUD_App.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Name = "Mary",
                Department = Dept.IT,
                Email = "mary@softec.com"
            },
            new Employee
            {
                Id = 2,
                Name = "john",
                Department = Dept.HR,
                Email = "john@softec.com"
            }
            );
        }
    }
}
