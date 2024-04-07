namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter letter or number to get Ascii code: ");
            int input = Console.Read();
            Console.WriteLine($"the ascii code for your input is: {input}");
        }
    }
}
