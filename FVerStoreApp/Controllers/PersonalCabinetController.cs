using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FVerStoreApp.Models;
using FVerStoreApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FVerStoreApp.Controllers
{
    public class PersonalCabinetController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        UserManager<User> _userManager;
        private OrderContext db;

        public PersonalCabinetController(OrderContext context, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            db = context;
        }
        RegisterViewModel model;
        public IActionResult Index() => View(_roleManager.Roles.ToList());

        public async Task<IActionResult> ChangePassword(string Email)
        {
            User user = await _userManager.FindByEmailAsync(Email);
            if (user == null)
            {
                return NotFound();
            }
            ChangePasswordViewModel model = new ChangePasswordViewModel { Id = user.Id, Email = user.Email };
            return View(model);

        }
        public IActionResult MyInsuranes()
        {
            var data = db.orders.AsNoTracking().ToList();
            return View(data);
        }
    }
}