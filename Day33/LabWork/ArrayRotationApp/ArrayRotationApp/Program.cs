
namespace ArrayRotationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] inputArry = {10, 20, 30, 40, 50, 60, 70};
            RotateArray(inputArry, 3);
        }
        static void RotateArray(int[] arr, int d)
        {
            int n = arr.Length;
            d = d % n; 

            ReverseArray(arr, 0, d - 1); 
            ReverseArray(arr, d, n - 1); 
            ReverseArray(arr, 0, n - 1); 
            foreach (int i in arr) {
                Console.WriteLine(i);
            }
        }

        private static void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
