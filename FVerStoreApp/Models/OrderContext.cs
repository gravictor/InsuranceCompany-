using FVerStoreApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<OrderViewModel> orders { get; set; }
        public OrderContext(DbContextOptions<OrderContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
