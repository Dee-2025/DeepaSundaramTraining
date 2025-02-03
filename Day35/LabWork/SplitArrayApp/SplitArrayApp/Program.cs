namespace SplitArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[] { "google.com", "tneb.org", "rrd.com", "amazon.in", "sc.com"};
            SplitArray(inputArray);
        }

        static void SplitArray(string[] inputArray)
        {
            string[] outputArray = new string[inputArray.Length];
            foreach (string item in inputArray)
            {
                bool isDotPresent = false;
                string beforeDot = string.Empty;
                
                foreach (char c in item)
                {
                    if (c == '.')
                    {
                        isDotPresent = true;
                        continue; 
                    }
                    if (!isDotPresent)                   
                          
                        beforeDot += c.ToString();                   
                }
                outputArray[Array.IndexOf(inputArray, item)] = beforeDot;
            }
            foreach (string item in outputArray)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
