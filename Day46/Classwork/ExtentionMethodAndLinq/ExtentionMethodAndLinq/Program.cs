

using ExtentionMethodAndLinq.Extentions;
using ExtentionMethodAndLinq.Models;
using System.Security.Cryptography.X509Certificates;

namespace ExtentionMethodAndLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();
            CaseStudy3();
            CaseStudy4();
            CaseStudy5();
            CaseStudy6();
            CaseStudy7();
        }
        static void CaseStudy1()
        {
            Func<string, bool> isALongName = CheckIfNameIsLong;
            Console.WriteLine(isALongName("Deepa Shanmuga Sundaram"));
        }
        static bool CheckIfNameIsLong(string name)
        {
            return name.Length > 8;
        }
        static void CaseStudy2()
        {
            Func<string, bool> isALongName = (name) => name.Length > 8;
            Console.WriteLine(isALongName("Deepa Shanmuga Sundaram"));

            Action<int, int> add = (a, b) => Console.WriteLine($"Result is {a + b}");
            add(10, 20);

            Predicate<int> isEvenNumber = (number) => number % 2 == 0;
            Console.WriteLine(isEvenNumber(10));
        }
        static void CaseStudy3()
        {
            string name = "Deepa";
            Console.WriteLine(name.HelloRRD());

            Account account = new Account { AccountNumber = 123, Name = "Deepa" };
            account.Print();
        }
        static void CaseStudy4()
        {
            IEnumerable<string> myNames = new string[] { "Deepa", "Shanmuga", "Sundaram" };
            IEnumerator<string> dataReader = myNames.GetEnumerator();
            while (dataReader.MoveNext())
            {
                Console.WriteLine(dataReader.Current);
            }
        }
        static void CaseStudy5()
        {
            IEnumerable<string> myNames = new string[] { "Deepa", "Shanmuga", "Sundaram" };
            foreach (var name in myNames)
            {
                Console.WriteLine(name);
            }
        }
        static void CaseStudy6()
        {
            IEnumerable<string> myNames = new string[] { "Deepa", "Shanmuga", "Sundaram" };
            myNames.OrderBy(name=> name.Length);
        }
        static void CaseStudy7()
        {
            var myNames = new string[] { "Deepa", "Shanmuga", "Sundaram" };
           var query =  myNames.Where(name => name.ToLower().Contains("s"));
            var myNamesWithS= query.ToList();
            Console.WriteLine(myNamesWithS.Count);
           myNamesWithS.ForEach(name => Console.WriteLine(name));
        }
    }
}
