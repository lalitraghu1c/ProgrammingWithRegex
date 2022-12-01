using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramWithRegex
{
    public class Email
    {
        const string EMAIL_PART_FIRST = "^[a-z]$";
        const string EMAIL_PART_SECOND = "^[a-zA-Z]+[@][a-zA-Z]{2,}$";
        public void EmailPartFirst()
        {
            Console.WriteLine("Enter your first Email Addrsss part");
            string input = Console.ReadLine();
            {
                if (Regex.IsMatch(input, EMAIL_PART_FIRST))
                    Console.WriteLine("Email is valid");
                else
                    Console.WriteLine("Email does not valid");
            }
        }
        public void EmailPartSecond()
        {
            Console.WriteLine("Enter your last Email Addrsss part");
            string input = Console.ReadLine();
            {
                if (Regex.IsMatch(input, EMAIL_PART_SECOND))
                    Console.WriteLine("Email is valid");
                else
                    Console.WriteLine("Email does not valid");
            }
        }
    }
}
