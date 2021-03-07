using System;

namespace _04.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double result = input * 2.54;

            Console.WriteLine(result);
        }
    }
}
