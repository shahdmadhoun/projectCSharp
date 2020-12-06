using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace project3
{
    public enum OrderStatus { InProgress, Pending, delivered }
    public class Order : IShoppingBag
    {
        public int ID { get; set; }
        public DateTime Date1 { get; set; }

        public OrderStatus status { get; set; }

        [NotMapped]
        public float Final_Cost { get; set; }

        public ICollection<TransactionItem> TItems { get; set; }
        public Customer Customer { get; set; }

        public void AddItem(TransactionItem item)
        {
            TItems.Add(item);
        }
        public void DeleteItem(TransactionItem item)
        {
            TItems.Remove(item);
        }
        public void UpdateQuantity(TransactionItem item, int quantity)
        {
            item.quantity = quantity;
        }

        public string PrintShoppingBag()
        {
            string s = $"ID = {ID} , Date: {Date1}, Status: {status}";
            foreach (TransactionItem i in TItems)
                s += $" , {i.ID} :  , {i.Product} , {i.quantity}";
            return s;
        }
    }
}
