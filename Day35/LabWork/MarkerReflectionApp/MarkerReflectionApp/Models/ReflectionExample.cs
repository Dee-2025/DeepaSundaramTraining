using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarkerReflectionApp.Models
{
    public class ReflectionExample
    {
        public static void FindMethodsNeedingAttention(Type classType)
        {
           
            var methods = classType.GetMethods();

            
            foreach (var method in methods)
            {
                var attribute = method.GetCustomAttribute<ThisMethodNeedsAttentionAttribute>();
                if (attribute != null)
                {
                    Console.WriteLine($"Method '{method.Name}' needs urgent attention: {attribute.Message}");
                }
            }
        }
    }
}
