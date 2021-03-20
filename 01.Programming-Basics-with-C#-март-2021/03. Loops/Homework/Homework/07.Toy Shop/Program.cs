using System;

namespace _07.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double talkingDollPrice = 3.00;
            double teddyBearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleNumber=int.Parse(Console.ReadLine());
            int talkingDollNumber=int.Parse(Console.ReadLine());
            int teddyBearNumber = int.Parse(Console.ReadLine());
            int minionNumber = int.Parse(Console.ReadLine());
            int truckNumber = int.Parse(Console.ReadLine());

            double totalPrice = (puzzlePrice * puzzleNumber
                + talkingDollPrice * talkingDollNumber
                + teddyBearPrice * teddyBearNumber
                + minionPrice * minionNumber
                + truckPrice * truckNumber);

            int numberOfToys = puzzleNumber + talkingDollNumber + teddyBearNumber + minionNumber + truckNumber;

            if (numberOfToys>=50)
            {
                totalPrice =totalPrice* 0.75;
            }
            totalPrice = totalPrice * 0.90;

            double moneyLeft = totalPrice - tripPrice;
            if (totalPrice >= tripPrice)
            {
                
                Console.WriteLine("Yes!" + " {0:f2}" + " lv left.", moneyLeft);
            }
            else
            {
                Console.WriteLine("Not enough money! " + "{0:F2}" + " lv needed.", Math.Abs(moneyLeft));
            }

        }
    }
}
