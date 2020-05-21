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
                        LongDesc ="Формула здоровья - это деньги на лечение в наиболее нужное время! Это страхование на случай болезней, требующих пребывания в стенах больницы, хирургического вмешательства или длительной реабилитации. Это быстрая выплата от нас, когда средства на лечение нужны больше всего",
                        Image="/images/img1.jpg",
                        Price=10,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 1,
                        Name="Оптимальная защита",
                        ShortDesc ="Классическая программа добровольной мед страховки",
                        LongDesc ="Оптимальная защита - это медицинское страхование, доступное каждому! Это классическая программа медицинского страхования. Ее можно приобрести для себя или своих близких. Почти все виды медицинской помощи - в государственных и частных клиниках Украины. Медицинский контакт-центр круглосуточно!",
                        Image="/images/img2.jpg",
                        Price=20,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 2,
                        Name="Защита для ребенка",
                        ShortDesc ="Страховка на случай травм и других внезапных неприятностей.",
                        LongDesc ="Добросовестные родители всячески способствуют всестороннему развитию своего ребенка, развивают его таланты, помогают ему найти свое место в мире и свое призвание. Специально для таких родителей или дедушек с бабушками, которые «вкладывают» душу и средства в своих детей, наша страховая компания разработала программу страхования «РЕБЕНОК».",
                        Image="/images/img3.jpg",
                        Price=5,
                        Category = _categoryInsurnce.AllCategories.First()
                    },
                    new Insurance{

                        ID = 3,
                        Name="Автоцивилка",
                        ShortDesc ="Материальная защита Вашей ответсвенности, быстрая оплата пострадавшей стороне.",
                        LongDesc ="При управлении любым транспортным средством всегда существует риск возникновения непредвиденной ситуации, при которой возможно повреждение другого транспортного средства или постороннего имущества, либо наезд (задание травм) на пешехода. Страховая компания возмещает причиненные убытки пострадавшей стороне и избавляет Вас от финансовых забот при возможном возникновении досадной ситуации. Не теряйте времени, купите полис осаго с доставкой сейчас!",
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
