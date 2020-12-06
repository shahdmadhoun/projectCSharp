using System;
using System.Collections.Generic;
using System.Text;

namespace project3
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public float Price { get; set; }
        public int Inventory_Level { get; set; }


        public TransactionItem transactionItem { get; set; }

    }
}
