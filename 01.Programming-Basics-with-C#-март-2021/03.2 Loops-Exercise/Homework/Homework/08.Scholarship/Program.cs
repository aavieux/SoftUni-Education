using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double note = double.Parse(Console.ReadLine());
            double minimalFamilyIncome = double.Parse(Console.ReadLine());

            bool canHaveSocialSchoolarship = false;
            bool canHaveExcellenceSchoolarship = false;
            double socialSchoolarship = 0.0;
            double excellenceSchoolarship = 0.0;
            if (income<minimalFamilyIncome && note > 4.50)
            {
                canHaveSocialSchoolarship = true;
                socialSchoolarship = 0.35 * minimalFamilyIncome;
            }
            if (note >= 5.50)
            {
                canHaveExcellenceSchoolarship = true;
                excellenceSchoolarship = 25 * note;
            }
            
            if (canHaveExcellenceSchoolarship || canHaveSocialSchoolarship == true)
            {

                if (canHaveSocialSchoolarship && canHaveExcellenceSchoolarship == true)
                {
                    if (socialSchoolarship > excellenceSchoolarship)
                    {
                        socialSchoolarshipMessage(socialSchoolarship);
                    }
                    else if (socialSchoolarship <= excellenceSchoolarship)
                    {
                        excellenceSchoolarshipMessage(excellenceSchoolarship);
                    }
                }
                else if (canHaveSocialSchoolarship == true && canHaveExcellenceSchoolarship == false)
                    socialSchoolarshipMessage(socialSchoolarship);

                else
                    excellenceSchoolarshipMessage(excellenceSchoolarship);
            }
            else
                Console.WriteLine("You cannot get a scholarship!");

            static void excellenceSchoolarshipMessage(double excellenceSchoolarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellenceSchoolarship)} BGN");
            }
            static void socialSchoolarshipMessage(double socialSchoolarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialSchoolarship)} BGN");
            }

        }
    }
}
