using System;

namespace _06.Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int statisticians = int.Parse(Console.ReadLine());
            double priceForCostume = double.Parse(Console.ReadLine());

            double filmDecorPrice = 0.10 * filmBudget;
            if (statisticians>150)
            {
                priceForCostume *= 0.90;
            }
            double finalCostumePriceForSpending = priceForCostume * statisticians;
            if (filmDecorPrice + finalCostumePriceForSpending > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs" +" {0:F2}" + " leva more.", Math.Abs(filmBudget - (filmDecorPrice + finalCostumePriceForSpending)));
            }
            else if (filmDecorPrice + finalCostumePriceForSpending <= filmBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with" + " {0:F2}" + " leva left.", filmBudget - (filmDecorPrice + finalCostumePriceForSpending));
            }
        }
    }
}
