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
        const string EMAIL_PART_FIRST = "^[a-z]";
        public void EmailPartFirst()
        {
            Console.WriteLine("Enter your Email Addrsss");
            string input = Console.ReadLine();
            {
                if (Regex.IsMatch(input, EMAIL_PART_FIRST))
                    Console.WriteLine("Email is valid");
                else
                    Console.WriteLine("Email does not valid");
            }
        }
    }
}
