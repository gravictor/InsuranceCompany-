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
        private readonly IAllInsurances _allInsurances;
        private readonly IInsuranceCategory _insuranceCategory;
        UserManager<User> _userManager;

        public InsurancesController(IAllInsurances allInsurances, IInsuranceCategory insuranceCategory, UserManager<User> userManager)
        {
            _allInsurances = allInsurances;
            _insuranceCategory = insuranceCategory;
            _userManager = userManager;
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
