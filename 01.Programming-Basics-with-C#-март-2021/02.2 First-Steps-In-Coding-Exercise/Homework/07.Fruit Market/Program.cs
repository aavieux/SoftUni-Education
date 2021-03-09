using System;

namespace _07.Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasInKG = double.Parse(Console.ReadLine());
            double orangesInKG = double.Parse(Console.ReadLine());
            double rasberryInKG = double.Parse(Console.ReadLine());
            double strawberryInKG = double.Parse(Console.ReadLine());

            double rasberryPrice = strawberryPrice / 2.00;
            double orangesPrice = rasberryPrice - rasberryPrice * 0.4;
            double bananasPrice = rasberryPrice - rasberryPrice * 0.8;

            double sum = strawberryPrice * strawberryInKG + rasberryPrice * rasberryInKG + orangesInKG * orangesPrice + bananasInKG * bananasPrice;
            Console.WriteLine(Math.Round(sum , 2));
        }
    }
}
