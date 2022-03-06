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
    }
}
