using System.Collections;
using System.Reflection;


namespace CustomerAorderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Customer> customerGroup = CaseStudy1();
            CaseStudy2(customerGroup);
        }
        public static Dictionary<string, Customer> CaseStudy1()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { CustomerId = 1, Name = "Deepa", Address = "123 Elm St", Email = "john@gmail.com", Phone = "123-456-7890", City = "Chennai" });
            customers.Add(new Customer { CustomerId = 2, Name = "Mathi", Address = "456 Oak St", Email = "mathi@gmail.com", Phone = "123-456-7890", City = "Madurai" });
            customers.Add(new Customer { CustomerId = 3, Name = "Saranya", Address = "789 Pine St", Email = "saranya@gmail.com", Phone = "123-456-7890", City = "Coimbatore" });
            customers.Add(new Customer { CustomerId = 4, Name = "Suganya", Address = "101 Cedar St", Email = "suganya@gmail.com", Phone = "123-456-7890", City = "Madurai" });
            customers.Add(new Customer { CustomerId = 5, Name = "Sathya", Address = "102 Cedar St", Email = "sathya@gmail.com", Phone = "123-456-7890", City = "Coimbatore" });
            Dictionary<string, Customer> customerGroup = Customer.GroupCutomers(customers);
            return customerGroup;

        }
        public static void CaseStudy2(Dictionary<string, Customer> customerGroup)
        {
            List<Order> orders = new List<Order>();
            Order order1 = new Order { OrderId = 1, OrderDate = DateTime.Now, Customer = customerGroup["Chennai"] };
            order1.AddItem(new OrderItem { OrderItemId = 1, Name = "Item1", Quantity = 2 });
            orders.Add(order1);
            Order order2 = new Order { OrderId = 2, OrderDate = DateTime.Now, Customer = customerGroup["Madurai"] };
            order2.AddItem(new OrderItem { OrderItemId = 2, Name = "Item2", Quantity = 3 });
            orders.Add(order2);

            foreach (Order order in orders)
            {
                order.PrintOrderDetails();
            }
        }

    }
}
