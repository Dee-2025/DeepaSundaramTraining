using ObjectReflectionApp.Model;

namespace ObjectReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReflectionAnalyzer.DoReflection(typeof(Account));
        }
    }
}
