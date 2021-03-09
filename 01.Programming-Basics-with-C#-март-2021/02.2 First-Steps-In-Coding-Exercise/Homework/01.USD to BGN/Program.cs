using System;

namespace _01.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double convertedPrice = input * 1.79549;

            Console.WriteLine(convertedPrice);
        }
    }
}
