using System;

namespace _05.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pass = "s3cr3t!P@ssw0rd";
            if (input == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
                Console.WriteLine("Wrong password!");
        }
    }
}
