using CustomerCommonLib;
using Deserialize.Model;
using System.Xml.Serialization;
using System;
namespace XMLSerilaization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XMLSerilaization();
            XmlDeSerialization();
        }

        private static void XMLSerilaization()
        {
            var c1 = new Customer
            {
                Id = 1,
                Name = "Deepa",
                Addresses = new List<Address> {
                 new Address { City="Chennai",Country="India" },
                 new Address { City="Coimbatore",Country="India" }
                }
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Customer));

            // Serialize the object to XML
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, c1);
                string xmlOutput = writer.ToString();
                var sw = new StreamWriter(@"customer.txt");
                sw.WriteLine(xmlOutput);
                sw.Close();
                Console.WriteLine("Serialized XML:\n" + xmlOutput);
            }

           
        }
        private static void XmlDeSerialization()
        {
           
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));

            string xmlInput = @"customer.txt";

            using (StringReader reader = new StringReader(xmlInput))
            {
                Customer customer = (Customer)serializer.Deserialize(reader);

                if(customer != null)
                {
                    Console.WriteLine($"Deserialized Object:\nName: {customer.Name}");
                    foreach (var address in customer.Addresses)
                    {
                        Console.WriteLine($"City: {address.City}, Country: {address.Country}");
                    }
                }
                
            }

        }
    }
}
