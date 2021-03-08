using System;

namespace _02.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = input * 180 / Math.PI;
            Console.WriteLine(Math.Round(result));
        }
    }
}
