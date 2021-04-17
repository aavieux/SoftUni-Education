using System;

namespace _07.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());
            double waterResistence = Math.Floor(meters / 15.00);
            waterResistence *= 12.5;
            double totalSecTime = meters * timeForOneMeter + waterResistence;

            if (totalSecTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSecTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalSecTime - record):F2} seconds slower.");
            }
        }
    }
}
