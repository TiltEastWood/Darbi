using System;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yout weight (KG): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height (CM): ");
            double height = Convert.ToDouble(Console.ReadLine());
            ConvertToLbsAndInches(weight, height);
            double BMIvalue = BMIcalculator(weight, height) * 10;
            BMIvalue = Math.Round(BMIvalue, 2);
            Console.WriteLine(BMIvalue);

            if (BMIvalue > 18.5 && BMIvalue < 25)
            {
                Console.WriteLine("You have optimal bodyweight.");
            }
            else if (BMIvalue <= 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (BMIvalue >= 25)
            {
                Console.WriteLine("You are overweight.");
            }    
        }
        static double BMIcalculator(double weight, double height)
        {
            double BMIvalue = 0;
            BMIvalue = (weight * 703) / (height * height);
            return BMIvalue;
        }
        static void ConvertToLbsAndInches(double weight, double height)
        {
            weight = weight * 2.20462;
            height = height * 0.393701;
        }
    }
}
