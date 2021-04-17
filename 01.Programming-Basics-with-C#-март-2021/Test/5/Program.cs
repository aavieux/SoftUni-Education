using System;

namespace _5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaPrice = 680;
            int mountainPrice = 499;

            int seaCount = int.Parse(Console.ReadLine());
            int moutainCount = int.Parse(Console.ReadLine());

            double profit = 0;

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "stop")
                {
                
                    break;
                }
                if (input == "sea" && seaCount != 0)
                {
                    profit += seaPrice;
                    seaCount--;
                }
                else if (input == "mountain" && moutainCount != 0)
                {
                    profit += mountainPrice;
                    moutainCount--;
                }

                if (moutainCount == 0)
                    if (seaCount == 0)
                        break;
            }
            if (moutainCount == 0 && seaCount == 0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {profit} leva.");

            
        }
    }
}
