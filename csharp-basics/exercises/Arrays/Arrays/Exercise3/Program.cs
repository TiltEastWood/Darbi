namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            int average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average = average + numbers[i];
            }
            average = average / numbers.Length;
        }
    }
}
