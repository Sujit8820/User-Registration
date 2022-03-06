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
    }
}
