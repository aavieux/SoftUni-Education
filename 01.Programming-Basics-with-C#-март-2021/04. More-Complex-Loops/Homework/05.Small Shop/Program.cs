using System;
using System.Collections.Generic;

namespace _05.Small_Shop
{
    class Program
    {

        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double coffee;
            double water;
            double beer;
            double sweets;
            double peanuts;
            switch (city)
            {
                case "Sofia":
                    coffee = 0.50;
                    water = 0.80;
                    beer = 1.20;
                    sweets = 1.45;
                    peanuts = 1.60;

                    Result(product, quantity, coffee, water, beer, sweets, peanuts);
                    break;
                case "Plovdiv":
                    coffee = 0.40;
                    water = 0.70;
                    beer = 1.15;
                    sweets = 1.30;
                    peanuts = 1.50;

                    Result(product, quantity, coffee, water, beer, sweets, peanuts);
                    break;
                    
                case "Varna":
                    coffee = 0.45;
                    water = 0.70;
                    beer = 1.10;
                    sweets = 1.35;
                    peanuts = 1.55;

                    Result(product, quantity, coffee, water, beer, sweets, peanuts);
                    break;

                default:
                    break;
            }
            static void Result(string product, double quantity, double coffee, double water, double beer, double sweets, double peanuts)
            {
                if (product == "coffee")
                {
                    Console.WriteLine(coffee * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(water * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(beer * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(sweets * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(peanuts * quantity);
                }
                return;
            }
        }   
    }
}
