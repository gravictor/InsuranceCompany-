using FVerStoreApp.Interfaces;
using FVerStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.mocks
{
    public class MockInsurances : IAllInsurances
    {
        private readonly IInsuranceCategory _categoryInsurnce = new MockCategory();
        public IEnumerable<Insurance> Insurances 
        {
            get
            {
                return new List<Insurance>
                {
                    new Insurance{
                        ID = 0,
                        Name="Формула здоровья",
                        ShortDesc ="Максимальная защита и финансовая поддержка во время лечения",
                        Image="/images/img1.jpg",
                        Price=10,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 1,
                        Name="Оптимальная защита",
                        ShortDesc ="Классическая программа добровольной мед страховки",
                        Image="/images/img2.jpg",
                        Price=20,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 2,
                        Name="Защита для ребенка",
                        ShortDesc ="Страховка на случай травм и других внезапных неприятностей.",
                        Image="/images/img3.jpg",
                        Price=5,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 3,
                        Name="Автоцивилка",
                        ShortDesc ="Материальная защита Вашей ответсвенности, быстрая оплата пострадавшей стороне.",
                        Image="/images/img4.jpg",
                        Price=40,
                        Category = _categoryInsurnce.AllCategories.Last()
                    }
                };

            }
        }

        public Insurance getObjectInsurance(int insuranceID)
        {
            throw new NotImplementedException();
        }
    }
}
