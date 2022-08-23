using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private string _name;
        private double _balance;

        public BankAccount(string yourName, double yourBalance)
        {
            this._name = yourName;
            this._balance = yourBalance;
        }
        public string ShowUserNameAndBalance()
        {
            return $"{_name}, ${_balance.ToString("F2")}";
        }
    }
}
