using FVerStoreApp.Interfaces;
using FVerStoreApp.Models;
using FVerStoreApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.Controllers
{
    public class InsurancesController:Controller
    {
        UserManager<User> _userManager;
        private OrderContext db;
        private readonly IAllInsurances _allInsurances;
        private readonly IInsuranceCategory _insuranceCategory;

        public InsurancesController(OrderContext context,IAllInsurances allInsurances, IInsuranceCategory insuranceCategory, UserManager<User> userManager)
        {
            _allInsurances = allInsurances;
            _insuranceCategory = insuranceCategory;
            _userManager = userManager;
            db = context;
        }
        public async Task<IActionResult> OrderAsync(string Email,string id)
        {
            List<Insurance> list = _allInsurances.Insurances.ToList();
            User user =  await _userManager.FindByEmailAsync(Email);
            if (user == null)
            {
                return NotFound();
            }
            OrderViewModel model = new OrderViewModel { Id = user.Id, Name=user.Name, Email = user.Email, Year = user.Year, Insurancess = list[Convert.ToInt32(id)].Name, price = list[Convert.ToInt32(id)].Price };

            return View(model);
        }
        [HttpPost]
        public IActionResult Order(OrderViewModel Orders)
        {
            db.orders.Add(Orders);
            db.SaveChanges();
            return View();
        }
        public async Task<IActionResult> OrderInsurance(string id)
        {
            if (User.Identity.IsAuthenticated)
            {
                User user = await _userManager.FindByIdAsync(id);

                if (user == null)
                {
                    return NotFound();
                }
                OrderModel model = new OrderModel { Id = user.Id, Name = user.Name, Age = Convert.ToInt32(2020 - user.Year).ToString(), Email = user.Email };
                return View(model);
            }
            return View();
        }
        public ViewResult List()
        {
            var insurances = _allInsurances.Insurances;
            return View(insurances);
        }
    }
}
