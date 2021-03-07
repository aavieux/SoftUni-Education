using System;

namespace _09.Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetres = double.Parse(Console.ReadLine());
            double prise = 7.61 * squareMetres;           
            double discount = 0.18 * prise;
            double finalPrise = prise-discount;

            Console.WriteLine($"The final price is: {finalPrise} lv.");
            Console.WriteLine($"The discount is: {discount} lv."); 


        }
    }
}
