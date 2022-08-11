using System;
using System.Linq;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtToReverse = "Happy Birthday";
            string txtToReverse1 = "MANY THANKS";
            string txtToReverse2 = "sPoNtAnEoUs";

            string reverse1 = ReverseCase(txtToReverse);
            Console.WriteLine(reverse1);
            string reverse2 = ReverseCase(txtToReverse1);
            Console.WriteLine(reverse2);
            string reverse3 = ReverseCase(txtToReverse2);
            Console.WriteLine(reverse3);

        }

        static string ReverseCase(string txtstring)
        {
            char[] str1 = txtstring.ToCharArray();
            
            for (int i = 0; i < str1.Length ; i++)
            {
                if (Char.IsUpper(str1[i]) == true)
                {
                    str1[i] = Char.ToLower(str1[i]);
                }
                else if (Char.IsLower(str1[i]))
                {
                    str1[i] = Char.ToUpper(str1[i]);
                }
            }
            return new string(str1);
           
        }
    }
}
