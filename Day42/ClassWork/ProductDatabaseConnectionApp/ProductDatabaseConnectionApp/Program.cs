
using Microsoft.Data.SqlClient;

namespace ProductDatabaseConnectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("select * from product", con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["name"]);
                            Console.WriteLine(reader["quantity"]);
                            Console.WriteLine(reader["price"]);
                        }
                    }
                }
            }
        }

        private static void CaseStudy1()
        {
            var connectionString = "server=.\\sqlexpress;database=rrd_db1;Integrated security=true;TrustServerCertificate=true";
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("connection opened connected to ");
                Console.WriteLine(con.Database);
                Console.WriteLine("connection state is ");
                Console.WriteLine(con.State);
            }
        }
    }
}