namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var all = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            foreach (var x in all)
            {
                Console.WriteLine((int)x);
            }
        }
    }
}
