using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    internal class Commission : Hourly
    {
        double totalSales = 0;
        double commissionRate;

        public Commission(double commissionRate, string eName, string eAddress, string ePhone, string socSecNumber, double rate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            this.commissionRate = commissionRate;
        }
        public void addSales(double totalSales)
        {
            this.totalSales += totalSales;
        }
        public override double Pay()
        {
            double pay = base.Pay();
            double payComRate = pay * commissionRate;
            return pay + payComRate;
        }
    }
}
