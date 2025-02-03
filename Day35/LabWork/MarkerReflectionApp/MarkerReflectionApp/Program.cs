using MarkerReflectionApp.Models;

namespace MarkerReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
               
                ReflectionExample.FindMethodsNeedingAttention(typeof(ClassA));
           
        }
    }
}
