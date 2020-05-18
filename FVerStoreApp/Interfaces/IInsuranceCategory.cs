using FVerStoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.Interfaces
{
    public interface IInsuranceCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
