using System;

namespace _04.Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesin1hour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine((pages/pagesin1hour)/days);
        }
    }
}
