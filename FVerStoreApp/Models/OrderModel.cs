using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.Models
{
    public class OrderModel
    {
        public string Id;
        public string Email { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Insurance { get; set; }
        public string countMonth { get; set; }
        public string Price { get; set; }

    }
}