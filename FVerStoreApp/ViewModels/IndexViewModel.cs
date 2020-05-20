using FVerStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<OrderModel> orderModels { get; set; }
        public IEnumerable<Insurance> insurances { get; set; }
    }
}
