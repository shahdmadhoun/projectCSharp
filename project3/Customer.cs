using System;
using System.Collections.Generic;
using System.Text;

namespace project3
{
    public class Customer
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public ICollection<Order> OrderList { get; set; }

    }
}
