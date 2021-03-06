﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.Net_Core_MVC_CRUD_App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_MVC_CRUD_App.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager) 
        {
            this.roleManager = roleManager;
        }
        
        [HttpGet]
        public IActionResult CreateRole ()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateRole (CreateRoleViewModel model)
        {
           if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);
                
                if(result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "administration");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            // The view is rendered with validation errors for user to fix.
            return View(model);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
    }
}