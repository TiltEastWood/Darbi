using System;

namespace exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            IsMoranNumber("132");
            IsMoranNumber("133");
            IsMoranNumber("134");
        }
        static void IsMoranNumber(string number)
        {
            int sum = 0;
            int inputNumber = Convert.ToInt32(number);
            for (int i = 0; i < number.Length; i++)
            { 
                sum = sum + number[i] - '0';
            }
            if (inputNumber % sum == 0) 
            {
                int Harshad = inputNumber / sum;
                if (CheckPrime(Harshad) == true)
                {
                    Console.WriteLine("M");
                    return;
                }
                Console.WriteLine("H");
                return;
            }
            Console.WriteLine("Neither");
            return;
        }
        static bool CheckPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
