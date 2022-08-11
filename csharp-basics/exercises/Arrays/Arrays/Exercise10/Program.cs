using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] result = new int[2];
            
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > 0)
                {
                    result[1] = result[1] + 1;
                }
                else if (ints[i] < 0)
                {
                    result[0] = result[0] + ints[i];
                }
            }
            Console.WriteLine($"{result[0]}, {result[1]}");
        }
        
    }
}
