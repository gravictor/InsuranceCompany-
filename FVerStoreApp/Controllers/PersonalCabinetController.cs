using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FVerStoreApp.Models;
using FVerStoreApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FVerStoreApp.Controllers
{
    public class PersonalCabinetController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<User> _userManager;
        public PersonalCabinetController(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        RegisterViewModel model;
        public IActionResult Index() => View(_roleManager.Roles.ToList());
    }
}