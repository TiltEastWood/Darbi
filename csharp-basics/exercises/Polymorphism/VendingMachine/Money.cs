using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public struct Money
    {
        public int Euros { get; set; }
        public int Cents { get; set; }

        public Money(int euros, int cents)
        {
            Euros = euros;
            Cents = cents;
        }

        public Money AddFunds(Money amount)
        {
            return new Money(Euros + amount.Euros, Cents + amount.Cents);
        }

        public Money RemoveFunds(Money amount)
        {
            if(amount.Cents > Cents)
            {
                Cents = Cents + (Euros * 100);
                Cents -= amount.Cents;
                Euros -= 1;
                return new Money(Euros, Cents);
            }

            return new Money(Euros - amount.Euros, Cents - amount.Cents);
        }

        public override string ToString()
        {
            return $"{Euros},{Cents} €";
        }

        public decimal NumericValue()
        {
            
            return Euros + Cents * (decimal)0.01;

        }
    }
}
    
