using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        string _name;
        double _balance;

        public Account(string name, double balance)
        {
            this._name = name;
            this._balance = balance;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var account = new BankAccount("Benson", 17.50);

            Console.WriteLine(account.ShowUserNameAndBalance());
        }
    }
}
