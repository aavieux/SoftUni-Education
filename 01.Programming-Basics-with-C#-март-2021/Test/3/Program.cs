using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double prise = 0.0;
            double prisePerdancer = 0.0;
            if (place == "Bulgaria")
            {
                prise = points * numberOfDancers;
                if (season == "winter")
                {
                    prise *= 0.92;
                }
                else if (season == "summer")
                {
                    prise *= 0.95;
                }
                double charity = 0.75 * prise;
                prise *= 0.25;
                prisePerdancer = prise / (numberOfDancers*1.00);
                Console.WriteLine($"Charity - {charity:f2}");
                Console.WriteLine($"Money per dancer - {prisePerdancer:f2}");
            }

            else if (place == "Abroad")
            {
                prise = 1.5 * (points * numberOfDancers);

                if (season == "winter")
                {
                    prise *= 0.85;
                }
                else if (season == "summer")
                {
                    prise *= 0.90;
                }
                double charity = 0.75 * prise;
                prise *= 0.25;
                prisePerdancer = prise / (numberOfDancers*1.00);
                Console.WriteLine($"Charity - {charity:f2}");
                Console.WriteLine($"Money per dancer - {prisePerdancer:f2}");
            }
        }
    }
}
