using System;

namespace _04.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string inputedUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            if (inputedUnit == "mm" && outputUnit == "m")
            {
                input /= 1000;
                Console.WriteLine("{0:F3}", input);
            }
            else if (inputedUnit == "mm" && outputUnit == "cm")
            {
                input /= 10;
                Console.WriteLine("{0:F3}", input);
            }
            else if (inputedUnit == "m" && outputUnit == "mm")
            {
                input *= 1000;
                Console.WriteLine("{0:F3}", input);
            }
            else if (inputedUnit == "m" && outputUnit == "cm")
            {
                input *= 100;
                Console.WriteLine("{0:F3}", input);
            }
            else if (inputedUnit == "cm" && outputUnit == "m")
            {
                input /= 100;
                Console.WriteLine("{0:F3}", input);
            }
            else if (inputedUnit == "cm" && outputUnit == "mm")
            {
                input *= 10;
                Console.WriteLine("{0:F3}",input);
            }
            else
                throw new ArgumentException();
        }
    }
}
