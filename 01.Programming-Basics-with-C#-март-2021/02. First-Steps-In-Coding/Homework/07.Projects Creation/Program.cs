using System;

namespace _07.Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {3*number} hours to complete {number} project/s.");
        }
    }
}
