using System.Security.Cryptography.X509Certificates;

namespace FindNextCharcter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Deepa";
            string outputString = FindNextCharacter(inputString);
            Console.WriteLine(outputString);
        }

        private static string FindNextCharacter(string inputString)
        {
            string outputString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                char c = inputString[i];
                if (c == 'z')
                {
                    outputString += 'a';
                }
                else if (c == 'Z')
                {
                    outputString += 'A';
                }
                else
                {
                    outputString += (char)(c + 1);
                }
            }
            return outputString;
        }
    }
}
