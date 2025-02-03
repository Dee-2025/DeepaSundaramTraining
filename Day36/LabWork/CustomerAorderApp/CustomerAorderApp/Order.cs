using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAorderApp
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }
        public object Customer { get; set; }
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void PrintOrderDetails()
        {
            Console.WriteLine("Order Id: " + OrderId);
            Console.WriteLine("Order Date: " + OrderDate);
            Console.WriteLine("Customer Id: " + ((Customer)Customer).CustomerId);
            Console.WriteLine("Customer Name: " + ((Customer)Customer).Name);
            Console.WriteLine("Customer Address: " + ((Customer)Customer).Address);
            Console.WriteLine("Customer Email: " + ((Customer)Customer).Email);
            Console.WriteLine("Customer Phone: " + ((Customer)Customer).Phone);
            Console.WriteLine("Order Items:");
            foreach (OrderItem item in Items)
            {
                Console.WriteLine("Item Id: " + item.OrderItemId);
                Console.WriteLine("Item Name: " + item.Name);
                Console.WriteLine("Item Quantity: " + item.Quantity);
            }
        }
    }
}
