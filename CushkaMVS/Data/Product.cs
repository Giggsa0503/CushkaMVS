using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CushkaMVS.Data
{
    public enum TypeType { Food,Domestic,Health,Cosmetic,Order}
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Prise { get; set; }
        public string Description { get; set;}
        public TypeType Type { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
