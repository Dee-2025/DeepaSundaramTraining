using CustomerCommonLib;
using System.Text.Json;

namespace Deserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"cust1.json");
            var jsonString = sr.ReadToEnd();

           

            var customer = JsonSerializer.Deserialize<Customer>(jsonString);

            if (customer != null)
            {
                Console.WriteLine(" customer :" + customer.Name);
                Console.WriteLine("address " + customer.Addresses.Count);
            }
        }
    }
}
