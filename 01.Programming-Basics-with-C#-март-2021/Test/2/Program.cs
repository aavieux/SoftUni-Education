using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForLoveMessage = 0.60;
            double priceForWaxRose = 7.20;
            double priceForKeyChain = 3.60;
            double priceForCaricature = 18.20;
            double priceForFortuneSuprise = 22.00;


            double priceForParty = double.Parse(Console.ReadLine());
            int numberOfLoveMessages = int.Parse(Console.ReadLine());
            int numberOfWaxRoses = int.Parse(Console.ReadLine());
            int numberOfKeyChains = int.Parse(Console.ReadLine());
            int numberOfCaricatures = int.Parse(Console.ReadLine());
            int numberOfFortuneSuprises = int.Parse(Console.ReadLine());
            bool canOrganiseParty = false;

            int numberOfOrderedProducts =
                  numberOfCaricatures
                + numberOfFortuneSuprises
                + numberOfKeyChains
                + numberOfLoveMessages
                + numberOfWaxRoses;
            double sum =
                  priceForLoveMessage * numberOfLoveMessages
                + priceForWaxRose * numberOfWaxRoses
                + priceForKeyChain * numberOfKeyChains
                + priceForCaricature * numberOfCaricatures
                + priceForFortuneSuprise * numberOfFortuneSuprises;

            if (numberOfOrderedProducts >= 25)
            {
                sum *= 0.65;
            }
            sum *= 0.90;

            if (sum >= priceForParty)
            {
                canOrganiseParty = true;
            }

            if (canOrganiseParty)
            {
                Console.WriteLine("Yes! "+ "{0:F2} lv left.", sum-priceForParty);
            }
            else
                Console.WriteLine("Not enough money! " + "{0:F2} lv needed.", Math.Abs(sum - priceForParty));
        }
    }
}
