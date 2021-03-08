using System;

namespace _03.Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0.0;
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            sum = deposit + months * ((deposit * percent/100) / 12);
            Console.WriteLine(sum);
        }
    }
}
