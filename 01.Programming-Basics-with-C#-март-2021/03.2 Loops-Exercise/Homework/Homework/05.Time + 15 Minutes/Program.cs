using System;

namespace _05.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
         {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes +15;

            int calculatedHours = 0;
            while (totalMinutes >= 60)
            {
                calculatedHours++;
                totalMinutes -= 60;

                if (calculatedHours >= 24)
                {
                    calculatedHours = 0;
                }
            }
            
            if (totalMinutes<10)
            {
                Console.WriteLine($"{calculatedHours}:0{totalMinutes}");
            }
            else
            {
                Console.WriteLine($"{calculatedHours}:{totalMinutes}");
            }
        }
    }
}
