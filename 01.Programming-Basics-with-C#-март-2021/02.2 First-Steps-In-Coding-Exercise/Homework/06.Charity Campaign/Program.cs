using System;

namespace _06.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cookers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            int cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakesPrice = 3.20;

            double sum = Math.Round
                (days * cookers * 
                ((cakes * cakePrice) + 
                (waffles * wafflePrice) + 
                (pancakes * pancakesPrice)),2);

            double finalSum = sum - (sum * 1.00 / 8.00);

            Console.WriteLine(Math.Round(finalSum,2));


        }
    }
}
