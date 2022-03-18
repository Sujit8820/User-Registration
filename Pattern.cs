using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace User_Registration
{
    public class Pattern
    {
        public static string REGEX_NAME = "^[A-Z][a-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z]{3,}(.[a-z]{3,})?@bl.co(.in)?$";
        public static string REGEX_MOBILENO = "^91[ ][6-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWARD = "^(?=.*[!@#$%^&*]{1})(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9@$!%*#?&]{8,}$";
        public static string ALL_EMAIL = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";





        public void ValidFirstName(string firstName)
        {
            string validOrNot = Regex.IsMatch(firstName, REGEX_NAME) ? "First name is valid" : "First name is invalid";
            Console.WriteLine($" {validOrNot}");
        }


        public void ValidLastName(string lastName)
        {
            string validOrNot = Regex.IsMatch(lastName, REGEX_NAME) ? "Last name is valid" : "Last name is invalid";
            Console.WriteLine($" {validOrNot}");
        }
        public void ValidEmail(string email)
        {
            string validOrNot = Regex.IsMatch(email, REGEX_EMAIL) ? "email is valid" : "email is invalid";
            Console.WriteLine($" {validOrNot}");
        }

        public void ValidMobileNo(string number)
        {
            string validOrNot = Regex.IsMatch(number, REGEX_MOBILENO) ? "Mobile number is valid" : "Mobile number is invalid";
            Console.WriteLine($" {validOrNot}");
        }

        public void ValidPassword(string password)
        {
            string validOrNot = Regex.IsMatch(password, REGEX_PASSWARD) ? "Password is valid" : "Password is invalid";
            Console.WriteLine($" {validOrNot}");
        }

        public void ValidAllEmail(string AllEmail)
        {
            string validOrNot = Regex.IsMatch(AllEmail, ALL_EMAIL) ? AllEmail + " is valid email" : AllEmail+" is invalid email";
            Console.WriteLine($" {validOrNot}");
        }
    }
}
