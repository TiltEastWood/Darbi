using System;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.weekDayInDutch(1970, 9, 21);
            date.weekDayInDutch(1945, 9, 2);
            date.weekDayInDutch(2001, 9, 11);
        }
    }
}
