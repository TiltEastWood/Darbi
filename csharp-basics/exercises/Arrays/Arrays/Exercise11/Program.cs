using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nemo1 = "I am finding Nemo !";
            string nemo2 = "Nemo is me";
            string nemo3 = "I Nemo am";

            string find = "Nemo";

            string[] words = nemo1.Split(' ');
            string[] words2 = nemo2.Split(' ');
            string[] words3 = nemo3.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == find)
                {
                    Console.WriteLine("I found Nemo at " + i);
                }
            }
            for (int i = 0; i < words2.Length; i++)
            {
                if (words2[i] == find)
                {
                    Console.WriteLine("I found Nemo at " + i);
                }
            }
            for (int i = 0; i < words3.Length; i++)
            {
                if (words3[i] == find)
                {
                    Console.WriteLine("I found Nemo at " + i);
                }
            }
        }
    }
}
