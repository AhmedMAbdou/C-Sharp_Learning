namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter original name: ");
            string origingal = Console.ReadLine();
            Console.Write("Enter old name: ");
            string old = Console.ReadLine();
            Console.Write("Enter new name: ");
            string _new = Console.ReadLine();
            Console.WriteLine($"The Result is: {origingal.Replace(old, _new, StringComparison.OrdinalIgnoreCase)}");
        }
    }
}
