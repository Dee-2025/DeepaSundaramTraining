class HelloWorldCommandLine
{
    static void Main(String[] userNames)
    {
        if (userNames.Length == 0)
        {
            Console.WriteLine("No arguments passed,pls pass argments");
            return;
        }
        foreach (string userName in userNames)
        {
            Console.WriteLine("Hello, " + userName + "!");
        }
        for (int i = userNames.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(userNames[i].ToUpper());
        }

    }
}