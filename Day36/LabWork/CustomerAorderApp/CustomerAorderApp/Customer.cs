using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAorderApp
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
            
        public string Phone { get; set; }
        public string City { get; set; }
        public static Dictionary<string, Customer> GroupCutomers(List<Customer> customers)
        {
            Dictionary<string, Customer> customerGroup = new Dictionary<string, Customer>();
            foreach (Customer customer in customers)
            {
                if (!customerGroup.ContainsKey(customer.City))
                {
                    customerGroup.Add(customer.City, customer);
                }
            }
            return customerGroup;
        }
    }
}
