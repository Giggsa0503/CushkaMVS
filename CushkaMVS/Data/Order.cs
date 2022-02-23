﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CushkaMVS.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId {get;set;}
        public virtual Product Product { get; set;}
        public int UserId { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
