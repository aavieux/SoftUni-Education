using System;

namespace _4_
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double sumOftemperaturePerLiter = 0.0;

            double sum = 0.0;
            for (int i = 0; i < days; i++)
            {
                double rakijaQuantity = double.Parse(Console.ReadLine());//
                double temperature = double.Parse(Console.ReadLine());
                sumOftemperaturePerLiter += temperature * rakijaQuantity;//
                sum += rakijaQuantity;
            }
            Console.WriteLine($"Liter: {sum:f2}");
            Console.WriteLine($"Degrees: {(sumOftemperaturePerLiter/sum):f2}");
            if (sumOftemperaturePerLiter / sum <38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (38<=sumOftemperaturePerLiter / sum && sumOftemperaturePerLiter / sum<42 )
            {
                Console.WriteLine("Super!");
            }
            else
                Console.WriteLine("Dilution with distilled water!" );

        }
    }
}
