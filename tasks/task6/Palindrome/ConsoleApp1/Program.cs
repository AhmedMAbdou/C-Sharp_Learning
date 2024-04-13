namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code for achieve from if word is palindrome or no
            while (true)
            {
                Console.Write("Enter your word: ");
                string word = Console.ReadLine();
                bool test = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] == word[word.Length - 1 - i])
                    {
                        test = true;
                    }
                    else
                        test = false;
                }
                Console.WriteLine(test);
            }
        }
    }
}
