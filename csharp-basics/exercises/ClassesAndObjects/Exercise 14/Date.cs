using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    internal class Date
    {
        public void weekDayInDutch(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            Console.WriteLine(dt.ToString("D",CultureInfo.GetCultureInfo("nl-NL")));
        }
    }
}
