using System;

namespace _6_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int a = 2; a <= num1; a += 2)
            {
                for (int l = 2; l <= num2; l++)
                {
                    for (int e = 2; e <= num3; e += 2)
                    {
                        if (l == 2 || l == 3 || l == 5 || l == 7)
                        {
                            Console.WriteLine($"{a} {l} {e}");//xa
                        }
                    }
                }
            }


        }
    }
}
