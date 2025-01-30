namespace FileWritingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFilePath = @"C:\WorkSpace\training\DeepaSundaramTraining\Day32\LabWork\FileWritingApp\output.txt";

            Console.WriteLine("Enter your Name");           
            File.WriteAllText(outputFilePath, $"User Name: {Console.ReadLine()}");
            Console.WriteLine("Enter your Address");
            File.AppendAllText(outputFilePath, $"\nUser Address: {Console.ReadLine()}");
            
        }
    }
}
