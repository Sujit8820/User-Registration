﻿// See https://aka.ms/new-console-template for more information
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
            string firstName = Console.ReadLine();
            pattern.ValidFirstName(firstName);


            Console.Write("\nEnter last name: ");
            string lastName = Console.ReadLine();
            pattern.ValidLastName(lastName);



        }

    }
}