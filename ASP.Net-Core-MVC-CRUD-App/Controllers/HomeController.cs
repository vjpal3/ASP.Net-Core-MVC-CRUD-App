﻿using System;
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
        public ViewResult Index()
        {
            var model = employeeRepository.GetAllEmployees();
            return View(model);
        }

        public ViewResult Details(int? id)
        {
            Employee model = employeeRepository.GetEmployee(id ?? 1);
            return View(model);
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
