namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your num: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("your array is: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
