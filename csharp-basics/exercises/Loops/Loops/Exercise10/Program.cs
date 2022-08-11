using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min?");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max?");
            int max = Convert.ToInt32(Console.ReadLine());
            int count = max - min + 1;
            int[] intArr = new int[count];

            for (int i = 0; i < count; i++)
            {
                intArr[i] = min;
                min++;
            }
            foreach (int i in intArr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            var result = ShiftArr(intArr);

            for (int i = 0; i < count; i++)
            {
                foreach (int integer in result)
                {
                    Console.Write(integer);
                }

                Console.WriteLine();

                result = ShiftArr(result);
            }
        }
        static int[] ShiftArr(int[] arr)
        {
            int[] resArr = new int[arr.Length];
            Array.Copy(arr, resArr, arr.Length);


            for (int i = 0; i < resArr.Length - 1; i++)
            {
                resArr[i] = arr[i + 1];
            }

            resArr[resArr.Length - 1] = arr[0];

            return resArr;
        }
    }
}
