using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkerReflectionApp.Models
{
    public class ClassA
    {
        [ThisMethodNeedsAttention("M1 needs urgent attention.")]
        public void M1()
        {
           Console.WriteLine("M1");
        }

        [ThisMethodNeedsAttention("M2 needs urgent attention.")]
        public void M2()
        {
           Console.WriteLine("M2");
        }

        public void M3()
        {
          Console.WriteLine("M3");
        }

        [ThisMethodNeedsAttention("M4 needs urgent attention.")]
        public void M4()
        {
            Console.WriteLine("M4");
        }
    }
}

