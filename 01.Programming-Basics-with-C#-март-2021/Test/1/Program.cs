using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForProcessor = double.Parse(Console.ReadLine());
            double priceForGraphicsCard = double.Parse(Console.ReadLine());
            double priceForRAM = double.Parse(Console.ReadLine());
            int numberOfRAMs = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double discountedGraphicsCardPrice = priceForGraphicsCard - discount * priceForGraphicsCard;
            double discountedProcessorPrice = priceForProcessor - discount * priceForProcessor;

            double sum = discountedGraphicsCardPrice + discountedProcessorPrice + priceForRAM*numberOfRAMs;


            Console.WriteLine("Money needed - " + "{0:F2} leva.", sum*1.57);
        }
    }
}
