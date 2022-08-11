using System;
using System.Collections.Generic;

namespace Exercise8
{
    class Program
    {
        public static List<char> chars = new List<char>();
        static void Main(string[] args)
        {
            var words = new List<string>();
            words.Add("codelex");
            words.Add("programming");
            words.Add("learn");
            words.Add("computer");

            Random rnd = new Random();
            string word = words[rnd.Next(0, words.Count)];

            bool runGame = true;
            string underLine = new string('_', word.Length);
            char[] toCharArray = underLine.ToCharArray();

            while (runGame == true)
            {
                Console.WriteLine("Guess a letter: ");
                char userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine(new string(toCharArray));
                
                for (int i = 0; i < word.Length; i++)
                {
                    if (userInput == word[i])
                    {
                        toCharArray[i] = userInput;
                    }
                    else if (word.Contains(userInput) == false)
                    {
                        chars.Add(userInput);
                    }
                }
                if (new string(toCharArray) == word)
                {
                    runGame = false;
                    Console.WriteLine("You guessed right!");
                }
            }
        }
    }
}
