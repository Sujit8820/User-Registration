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
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";

        public void ValidFirstName(string firstName)
        {
            string validOrNot = Regex.IsMatch(firstName, REGEX_FIRSTNAME) ? "First name is valid" : "First name is invalid";
            Console.WriteLine($"\n {validOrNot}");
        }
    }
}
