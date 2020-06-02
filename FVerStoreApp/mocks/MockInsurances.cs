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
                        Name="Формула здоров'я",
                        ShortDesc ="Максимальная защита и финансовая поддержка во время лечения",
                        LongDesc ="Формула здоров'я - це гроші на лікування в потрібний час! Це страхування на випадок хвороб потребуючих перебування у стінах лікарні, хірургічного втручання або тривалої реабілітації. Це швидка виплата від нас, коли кошти на лікування потрібні більш за все",
                        Image="/images/img1.jpg",
                        Price=10,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 1,
                        Name="Оптимальний захист",
                        ShortDesc ="Класична програма медичної страховки",
                        LongDesc ="Оптимальний захист - це медичне страхування, доступне кожному! Це класична програма медичного страхування. Її можна придбати для себе або своїх близьких. Майже всі види медичної допомоги - в державних і приватних клініках України. Медичний контакт-центр цілодобово!",
                        Image="/images/img2.jpg",
                        Price=20,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 2,
                        Name="Захист  для дитини",
                        ShortDesc ="Страховка на випадок травм і інших раптових неприємностей.",
                        LongDesc ="Сумлінні батьки всіляко сприяють всебічному розвитку своєї дитини, розвивають його таланти, допомагають йому знайти своє місце в світі і своє покликання. Спеціально для таких батьків чи дідусів з бабусями, які «вкладають» душу і кошти в своїх дітей, наша страхова компанія розробила програму страхування «ДИТИНА».",
                        Image="/images/img3.jpg",
                        Price=5,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 3,
                        Name="Машина під захистом",
                        ShortDesc ="Матеріальна захист Вашої відповідальності, швидка оплата постраждалій стороні.",
                        LongDesc ="При управлінні будь-яким транспортним засобом завжди існує ризик виникнення непередбаченої ситуації, при якій можливе пошкодження іншого транспортного засобу або стороннього майна, або наїзд (завдання травм) на пішохода. Страхова компанія відшкодовує завдані збитки потерпілій стороні і позбавляє Вас від фінансових турбот при можливому виникненні прикрої ситуації. Не втрачайте часу, купите поліс з доставкою зараз!",
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
