using FVerStoreApp.Interfaces;
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

        public InsurancesController(IAllInsurances allInsurances, IInsuranceCategory insuranceCategory)
        {
            _allInsurances = allInsurances;
            _insuranceCategory = insuranceCategory;
        }

        public ViewResult List()
        {
            var insurances = _allInsurances.Insurances;
            return View(insurances);
        }
    }
}
