using System;

namespace _05.Birthday_party
{		

    class Program
    {
        static void Main(string[] args)
        {
            double rentPrice = double.Parse(Console.ReadLine());
            double cakePrice = 0.2 * rentPrice;
            double drinksPrice = cakePrice - cakePrice * 0.45;
            double animatorsPrice = 1.00/3.00*rentPrice;
            double sum = rentPrice + cakePrice + drinksPrice + animatorsPrice;

            Console.WriteLine(sum);
        }
    }
}
