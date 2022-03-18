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

           /* Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            pattern.ValidFirstName(firstName);


            Console.Write("\nEnter last name: ");
            string lastName = Console.ReadLine();
            pattern.ValidLastName(lastName);

            Console.Write("\nEnter email: ");
            string email = Console.ReadLine();
            pattern.ValidEmail(email);

            Console.Write("\nEnter mobile number: ");
            string number = Console.ReadLine();
            pattern.ValidMobileNo(number);
*/
           /* Console.Write("\nEnter password: ");
            string password = Console.ReadLine();
            pattern.ValidPassword(password);*/

            string[] AllEmail = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com",
                "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", 
                "abc+100@gmail.com", "abc@.com.my", ".abc@abc.com",
                "abc@abc@gmail.com", "abc..2002@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            foreach(string email in AllEmail)
            {
                pattern.ValidAllEmail(email);
            }

        }

    }
}