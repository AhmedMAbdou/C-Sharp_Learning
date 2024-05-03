namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of array 1: ");
            int Length_array1 = int.Parse(Console.ReadLine());

            int[] array1 = new int[Length_array1];
            for (int i = 0; i < Length_array1; i++)
            {
                Console.Write($"Enter the element {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*************************************************");

            Console.Write("Enter the length of array 2: ");
            int Length_array2 = int.Parse(Console.ReadLine());

            int[] array2 = new int[Length_array2];
            for (int i = 0; i < Length_array2; i++)
            {
                Console.Write($"Enter the element {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("*************************************************");


            int Lengthe_array1_array2 = array1.Length + array2.Length;

            int[] array3 = array1.Concat(array2).ToArray();
            for (int i = 0; i < Lengthe_array1_array2; i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
    }
}
