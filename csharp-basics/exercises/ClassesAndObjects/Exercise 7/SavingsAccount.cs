using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class SavingsAccount
    {
        private int annualInterest;
        private double balance;

        public SavingsAccount(int annualInterest, int balance)
        {
            this.annualInterest = annualInterest;
            this.balance = balance;
        }

        public void Withdrawn()
        {
            Console.WriteLine("How much money you want to withdrawal: ");
            int takeMoney = Convert.ToInt32(Console.ReadLine());
            balance = balance - takeMoney;
            Console.WriteLine("New balance now: " + balance);
        }
        
        public void Deposit()
        {
            Console.WriteLine("How much money you want to deposit: ");
            int putMoney = Convert.ToInt32(Console.ReadLine());
            balance = balance + putMoney;
            Console.WriteLine("New balance now: " + balance);
        }

        public double monthlyInterest()
        {
            double monthlyinterest = balance * (annualInterest / 12);
            balance += monthlyinterest;
            return monthlyinterest;
        }

        public void BalanceOfSavings()
        {
            Console.WriteLine("How long you want to deposit: ");
            int depositMonths = Convert.ToInt32(Console.ReadLine());

            double totaldeposit = 0;
            double totalwithdrawn = 0;
            double totalInterest = 0;
            
            for (int i = 0; i < depositMonths; i++)
            {
                double beforeDeposit = balance;
                Deposit();
                totaldeposit = totaldeposit + (balance - beforeDeposit);
                double beforeWithdrawn = balance;
                Withdrawn();
                totalwithdrawn = totalwithdrawn + (beforeWithdrawn - balance);
                totaldeposit = balance * depositMonths;
                totalInterest += monthlyInterest();
            }
            Console.WriteLine(totaldeposit);
            Console.WriteLine(totalwithdrawn);
            Console.WriteLine(totalInterest);
            Console.WriteLine(balance);
        }
    }
}
