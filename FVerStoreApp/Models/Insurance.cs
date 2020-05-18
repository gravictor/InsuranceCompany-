using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVerStoreApp.Models
{
    public class Insurance
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string Image { get; set; }
        public ushort Price { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
