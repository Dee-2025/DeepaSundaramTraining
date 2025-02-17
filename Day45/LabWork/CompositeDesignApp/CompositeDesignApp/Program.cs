using CompositeDesignApp.Model;

namespace CompositeDesignApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStorageItem file1 = new Files("file1.txt", 20);
            IStorageItem file2 = new Files("file2.txt", 50);
            IStorageItem file3 = new Files("icon.png", 50);

            
            Folders folder1 = new Folders("Documents");
            Folders folder2 = new Folders("Images");
            Folders folder3 = new Folders("Icons");


            folder2.Add(folder3);
          
            folder1.Add(file1);
            folder2.Add(file2);
            folder3.Add(file3);
            

            
            Folders rootFolder = new Folders("Root");
            rootFolder.Add(folder1);
            rootFolder.Add(folder2);

            
            rootFolder.Display(3);
        }
    }
}
