namespace ReverseArray_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "reverse", "this", "array","without","another","array" };
           
            ReverseArray(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        static void ReverseArray(string[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                string temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }
    }
}
