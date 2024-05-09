namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers of elements of array: ");
            string numbers = Console.ReadLine();
            int new_numbers = int.Parse(numbers);
            //this line=two lines up {int new_numbers = int.Parse(Console.ReadLine())};
            string[] arr = new string[new_numbers];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter your array: ");
                arr[i] = Console.ReadLine();
                int new_arr = int.Parse(arr[i]);
            }
            //Array.Reverse(arr);
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
