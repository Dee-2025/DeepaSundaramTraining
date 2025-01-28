using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplimentationApp.Models
{
    internal class Boy:IEmotionable,IManarable
    {
        public void Cry()
        {
            Console.WriteLine($"Boys cry");
        }

        public void Depart()
        {
            Console.WriteLine($"Boys Say Good Bye");
        }

        public void Eat()
        {
            Console.WriteLine($"Boys Eat");
        }

        public void Laugh()
        {
            Console.WriteLine($"Boys Laugh");
        }

        public void Sleep()
        {
            Console.WriteLine($"Boys Sleep");
        }

        public void Wish()
        {
            Console.WriteLine($"Boys Say Good Moring");
        }
    }
}
