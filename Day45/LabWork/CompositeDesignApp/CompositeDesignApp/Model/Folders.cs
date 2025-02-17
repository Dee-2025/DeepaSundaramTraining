using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignApp.Model
{
    public class Folders: IStorageItem
    {
        public string Name { get; private set; }
        private List<IStorageItem> _items;

        public Folders(string name)
        {
            Name = name;
            _items = new List<IStorageItem>();
        }

        public void Add(IStorageItem item)
        {
            _items.Add(item);
        }

        public void Display(int indentationLevel)
        {
           
            Console.WriteLine(new string(' ', indentationLevel * 2) + $"Folder: {Name}");
            foreach (var item in _items)
            {
                item.Display(indentationLevel + 1); 
            }
        }   
    }
    
}
