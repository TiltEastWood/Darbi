using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string usersSentence = Console.ReadLine();
            int CountUpperChar = 0;
            for (int i = 0; i < usersSentence.Length; i++)
            {
                if (char.IsUpper(usersSentence[i]))
                {
                    CountUpperChar++;
                }
            }
            Console.WriteLine(CountUpperChar);
        }
    }
}
