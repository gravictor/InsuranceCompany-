using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
        public string Desc { get; set; }
        public List<Insurance> insurances { get; set; }

    }
}
