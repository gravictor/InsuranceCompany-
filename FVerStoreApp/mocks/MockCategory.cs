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
                    new Category{categoryName = "Медичні", Desc="Гарантія того, що у випадку захворювання ви отримуєте медичну допомогу"},
                    new Category{categoryName = "Автомобільні", Desc="Захист від непередбачених випадкыв на дорозі"}
                };
            }
        }
    }
}
