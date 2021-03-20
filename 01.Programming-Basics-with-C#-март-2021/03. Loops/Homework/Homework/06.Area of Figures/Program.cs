using System;

namespace _06.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputedFigure = Console.ReadLine();

            switch (inputedFigure)
            {
                case "square":
                    {
                        double aSqare = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f3}",aSqare*aSqare);
                    }
                    break;
                case "rectangle":
                    {
                        double aRectangle = double.Parse(Console.ReadLine());
                        double bRectangle= double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f3}",aRectangle*bRectangle);
                    }
                    break;
                case "circle":
                    {
                        double radiusCircle = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f3}", radiusCircle*radiusCircle * Math.PI);
                    }
                    break;
                case "triangle":
                    {
                        double atriangle = double.Parse(Console.ReadLine());
                        double ha = double.Parse(Console.ReadLine());
                        Console.WriteLine("{0:f3}", (atriangle * ha)/2);
                    }
                    break;
            }
        }
    }
}
