using System;

namespace _03.Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool evenOrNot = num % 2 == 0;

            if (evenOrNot == true)
            {
                Console.WriteLine("even");
            }
            else
                Console.WriteLine("odd");
        }
    }
}
