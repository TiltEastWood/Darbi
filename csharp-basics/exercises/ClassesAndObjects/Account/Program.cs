using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account A = new Account("Account A", 100);
            Account B = new Account("Account B", 0);
            Account C = new Account("Account C", 0);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Transfer(50.0, A, B);
            Transfer(25.0, B, C);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C); 
        }
        private static void Transfer(double money, Account acc1, Account acc2)
        {
            acc1.Withdrawal(money);
            acc2.Deposit(money);
        }
    }
}
