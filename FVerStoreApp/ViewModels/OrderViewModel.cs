using FVerStoreApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.ViewModels
{
    [Table("AspNetOrders")]
    public class OrderViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
        public string Insurancess { get; set; }
        public int price { get; set; }
        public int MonthCount { get; set; }
    }
}
