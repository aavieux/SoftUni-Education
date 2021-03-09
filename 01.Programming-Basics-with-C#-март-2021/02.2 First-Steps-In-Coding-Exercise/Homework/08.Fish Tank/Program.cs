using System;

namespace _08.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double V = length * width * height;
            double Litres = V * 0.001;
            double convertedPercent = percent * 0.01;

            double sum = Litres * (1 - convertedPercent);

            Console.WriteLine(sum);
        }
    }
}
