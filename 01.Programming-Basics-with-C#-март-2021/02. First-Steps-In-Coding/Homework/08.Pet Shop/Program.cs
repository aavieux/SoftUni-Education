using System;

namespace _08.Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());
            sum = dogs * 2.50 + others * 4;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
