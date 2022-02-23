using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CushkaMVS.Data
{
    public enum RoyalType { User, Admin}
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Password{ get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public RoyalType Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
