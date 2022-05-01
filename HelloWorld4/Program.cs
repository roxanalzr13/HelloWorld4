using System;

namespace HelloWorld4
{
    class Program
    {
        static void Main(string[] args)
        {
            //afisare PozitivNegativO
            //daca am -5, imi afiseaza "-"
            //daca am 5, imi afiseaza"+"
            //daca am 0, imi afiseaza "0"
            int x = -5;
            if (x > 0)
            {
                Console.WriteLine("+");
            }
            else if (x < 0)
            {

                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(x = 0);
            }
        }
    }
}


