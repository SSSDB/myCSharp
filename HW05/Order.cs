using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
[Serializable]
   public class Order
    {
        public int ID { get; set; }
        public Customer customer = new Customer();
        private double sumPrice ;
        public double SumPrice
        {
            get
            {
                this.sumPrice = 0;
                foreach (var orderItem in OrderItems.Values)
                {
                    sumPrice += orderItem.UnitPrice * orderItem.Amount;
                }
                return sumPrice;
            }
            set => sumPrice = value;
        }

        internal Dictionary<string, OrderItem> OrderItems { get => orderItems; set => orderItems = value; }
        private Dictionary<string, OrderItem> orderItems;

        public Order() { }
        public Order(string name,  int id )
        {
            this.ID = id;
            //Time = time;
            this.customer.Name=name;
            this.OrderItems = new Dictionary<string, OrderItem>();
            // Tel = telephone;
        }
       
        public void AddOrderItem(string item, int amount, double unitprice)
        {
            OrderItem orderItem = new OrderItem(item, amount,unitprice);
            if (OrderItems.Keys.Contains(item))
            {
                OrderItems[item].Amount += amount;
            }
            else OrderItems.Add(item, new OrderItem(item, amount, unitprice));           
        }

        public void DeleteItems(string item, int amount) 
        {
            if (OrderItems.Keys.Contains(item) && OrderItems[item].Amount > amount)
                OrderItems[item].Amount -= amount;
            else if (OrderItems.Keys.Contains(item) && OrderItems[item].Amount <= amount)
                OrderItems.Remove(item);
        }

        public override string ToString()
        {
            return $"[ID={ID}, customer={customer.Name},SumPrice={sumPrice}]" ;
        }
        public  string ToString1()
        {
            string result = "";
            result += "-----------------------------\n";
            result += "ID: " + ID + "\n";
            result += "Customer: " + customer.Name + "\n";
            result += "-----------------------------\n";
            result += "Item Name   Price    Quantity\n";
            foreach (var orderItem in OrderItems.Values)
            {
                result += orderItem.ToString();
            }
            result += "-----------------------------\n";
            result += "Total Price: " + SumPrice + "\n";
            result += "-----------------------------\n";
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   EqualityComparer<Customer>.Default.Equals(customer, order.customer) &&
                   EqualityComparer<Dictionary<string, OrderItem>>.Default.Equals(OrderItems, order.OrderItems) &&
                   sumPrice == order.sumPrice;
        }      
    }
}
