using System;
using System.Collections.Generic;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, string> courses = new Dictionary<string, string>()
           {
               {"English III", "Ms. Lapan" },
               {"Precalculus", "Mrs. Gideon"},
               {"Music Theory", "Mr. Davis"},
               {"Biotechnology", "Ms. Palmer"},
               {"Principles of Technology I", "Ms. Garcia"},
               {"Latin II", "Mrs. Barnett" },
               {"Ap US History", "Ms. Johannessen" },
               {"Buisness Computer Information Systems", "Mr. James" }
           };
            int counter = 1;
            Console.WriteLine("+------------------------------------------------------------+");
            foreach (var course in courses)
            {
                string line = String.Format("|{0,1}|{1,40}|{2,17}|", counter,course.Key,course.Value);
                Console.WriteLine(line);
                counter++;
            }
            Console.WriteLine("+------------------------------------------------------------+");
        }
    }
}
