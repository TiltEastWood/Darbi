using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; 
            int n;
            

            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            
            int result = i;

            for (int z = 1; z < n; z++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
