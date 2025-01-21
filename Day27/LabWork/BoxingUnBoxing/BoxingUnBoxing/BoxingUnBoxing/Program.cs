namespace BoxingUnBoxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] numberArray = { 9, 1, 2, 3, 4, 5, 6, 7 };

            int maxNumber = 0;
            int sumOfArray = 0;
            foreach (var number in numberArray)
            {

                if (maxNumber < (int)number) { maxNumber = (int)number; }
                sumOfArray += (int)number;
            }
            Console.WriteLine($"Max Number is :{maxNumber}");
            Console.WriteLine($"Sum of the Array is:{sumOfArray}");
            Console.WriteLine($"Ave Of Array is:{(sumOfArray / numberArray.Length)}");

            

            object[] inputArray = { "Find", "Maximummmm", "Characters", "in", "this", "String", "Array" };
            var result = FindBiggestStringsInTheArray(inputArray);

            foreach (var item in result)
            {
                Console.WriteLine($"Biggest String in the input array is :{item}");
            }
        }
        static object[] FindBiggestStringsInTheArray(object[] inputArray)
        {
            
            int maximumNumber = 0;

            foreach (var arrayString in inputArray)
            {
                int counter = 0;

                foreach (var character in (string)arrayString)
                {
                    counter++;

                }
                if (counter > maximumNumber)
                {
                    maximumNumber = counter;
                }
            }
            int count = 0;
            foreach (var arrayString in inputArray)
            {
                if (((string)arrayString).Length == maximumNumber)
                {
                    count++;
                }
            }
            object[] outPutArray = new object[count];
            int j = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {

                if (((string)inputArray[i]).Length == maximumNumber)
                { 
                    outPutArray[j] = inputArray[i];
                    j++;
                }
            }
            return outPutArray;
            
        }
    }
}
