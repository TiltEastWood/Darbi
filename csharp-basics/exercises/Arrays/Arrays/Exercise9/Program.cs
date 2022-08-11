using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"mavis", "senaida", "letty"};
            string[] names1 = { "samunel", "MABELLE", "letitia", "meridith" };
            string[] names3 = { "Slyvia", "Kristal", "Sharilyn", "Calista" };

            ToUpperLetter(names);
            ToUpperLetter(names1);
            ToUpperLetter(names3);
        }
        static void ToUpperLetter(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToLower();
                char firstLetter = names[i][0];
                firstLetter = Char.ToUpper(firstLetter);
                names[i] = firstLetter + names[i].Remove(0, 1);
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
