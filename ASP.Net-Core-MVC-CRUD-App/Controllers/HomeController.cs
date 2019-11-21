using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_Core_MVC_CRUD_App.Models;

namespace ASP.Net_Core_MVC_CRUD_App.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;  
        }
        public string Index()
        {
            return employeeRepository.GetEmployee(1).Name;
        }

        public JsonResult Details()
        {
            Employee model = employeeRepository.GetEmployee(1);
            return Json(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
