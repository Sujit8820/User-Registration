// See https://aka.ms/new-console-template for more information
using System;
namespace User_Registration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to User Registration program");
            Pattern pattern = new Pattern();

            Console.Write("Enter first name: ");
            string name = Console.ReadLine();

            pattern.ValidFirstName(name);

        }

    }
}