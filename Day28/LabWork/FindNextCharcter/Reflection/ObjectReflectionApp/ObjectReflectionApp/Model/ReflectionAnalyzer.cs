using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectReflectionApp.Model
{
    public class ReflectionAnalyzer
    {
        public static void DoReflection(Type type)
        {

            MethodInfo[] methods = type.GetMethods();
            ConstructorInfo[] constructors = type.GetConstructors();           
            PropertyInfo[] properties = type.GetProperties();

            
            Console.WriteLine($"Reflection analysis for type {type.FullName}:");
            Console.WriteLine($"Number of methods: {methods.Length}");
            Console.WriteLine("Methods: " + string.Join(", ", methods.Select(m => m.Name)));
            Console.WriteLine($"Number of constructors: {constructors.Length}");
            Console.WriteLine("Constructors: " + string.Join(", ", constructors.Select(c => c.Name)));
            Console.WriteLine($"Number of properties: {properties.Length}");
            Console.WriteLine("Properties: " + string.Join(", ", properties.Select(p => p.Name)));
        }
    }

}
