namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var inputArray = new int[] { 13, 22, 63, 49, 54 };
            var outputArray = sumOfArray(inputArray);
            foreach (var item in outputArray)
            {
                Console.WriteLine(item);
            }
        }
        static int[] sumOfArray(int[] inputArray)
        {
            
            var outputArray = new int[inputArray.Length-1];
            int outputArrayIndex = 0;
            for (int i = 0; i < inputArray.Length-1; i++)
            {
               outputArray[outputArrayIndex] = inputArray[i] + inputArray[i + 1];
               outputArrayIndex++;
            }
            return outputArray;
        }
    }
}
