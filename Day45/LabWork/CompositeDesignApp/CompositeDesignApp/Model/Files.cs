using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignApp.Model
{
    
    
    public class Files : IStorageItem
    {
        public string Name { get; private set; }
        public int Size { get; private set; }

        public Files(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public void Display(int indentationLevel)
        {
            
            Console.WriteLine(new string(' ', indentationLevel * 2) + $"File: {Name}, Size: {Size}KB");
        }
    }

}
