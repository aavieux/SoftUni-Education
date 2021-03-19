using System;

namespace _01.Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            if (input >=5.50 && input<=6.00)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
