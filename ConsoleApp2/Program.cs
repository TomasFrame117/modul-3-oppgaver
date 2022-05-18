using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Venligst skriv in passordlengde.");
            string passwordLength = Console.ReadLine();

            string pattren = "lLssdd";
            var a = Validate(passwordLength);
        }
        static bool Validate(string passwordLength)
        {
            foreach (var C in passwordLength)
            {
                bool Pass = char.IsDigit(C);
                if (Pass == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
