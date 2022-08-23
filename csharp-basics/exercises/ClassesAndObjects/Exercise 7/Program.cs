using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount Account = new SavingsAccount(4, 100);

            while (true)
            {
                Console.WriteLine("Choose the operation");
                Console.WriteLine("Choose 0 to Exit");
                Console.WriteLine("Choose 1 to withdraw");
                Console.WriteLine("Choose 2 to deposit");
                Console.WriteLine("Choose 3 to calculate interest");
                Console.WriteLine("Choose 4 to show savings");

                int n = Convert.ToInt16(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        Account.Withdrawn();
                        break;
                    case 2:
                        Account.Deposit();
                        break;
                    case 3:
                        Account.monthlyInterest();
                        break;
                    case 4:
                        Account.BalanceOfSavings();
                        break;
                    default:
                        return;

                }
            }
        }
    }
}
