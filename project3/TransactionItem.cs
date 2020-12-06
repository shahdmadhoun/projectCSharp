using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace project3
{
    public class TransactionItem
    {
        public int ID { get; set; }
        public int quantity { get; set; }

        [NotMapped]
        public float CostPerItem { get; set; }

        public Order Order { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
