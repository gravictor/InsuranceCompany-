using FVerStoreApp.Interfaces;
using FVerStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.mocks
{
    public class MockCategory : IInsuranceCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "Медицинские", Desc="Гарантия того, что в случае болезни вы получаете мед помощь"},
                    new Category{categoryName = "Автомобильные", Desc="Защита от непредвиденных ситуаций на дороге"}
                };
            }
        }
    }
}
