using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplimentationApp.Models
{
    internal class Man : IManarable
    {
        public void Depart()
        {
            Console.WriteLine($"Man Says Good Bye");
        }

        public void Eat()
        {
            Console.WriteLine($"Man likes to Eat");
        }

        public void Sleep()
        {
            Console.WriteLine($"Man likes to sleep");
        }

        public void Wish()
        {
            Console.WriteLine($"Man says Good Morning");
        }
    }
}
