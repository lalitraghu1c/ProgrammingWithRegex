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
        const string EMAIL_PART_THIRD = "^[a-zA-Z]+[@]([a-zA-Z]{2,})+[.]([a-z]{2,})$";
        const string EMAIL_PART_OPTIONAL = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";


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
            Console.WriteLine("Enter your second Email Addrsss part");
            string input = Console.ReadLine();
            {
                if (Regex.IsMatch(input, EMAIL_PART_SECOND))
                    Console.WriteLine("Email is valid");
                else
                    Console.WriteLine("Email does not valid");
            }
        }
        public void EmailPartThird()
        {
            Console.WriteLine("Enter your all Email Addrsss part");
            string input = Console.ReadLine();
            {
                if (Regex.IsMatch(input, EMAIL_PART_THIRD))
                    Console.WriteLine("Email is valid");
                else
                    Console.WriteLine("Email does not valid");
            }
        }
        public void EmailPartOptional()
        {
            Console.WriteLine("Enter your optional Email Addrsss part");
            string input = Console.ReadLine();
            {
                if (Regex.IsMatch(input, EMAIL_PART_OPTIONAL))
                    Console.WriteLine("Email is valid");
                else
                    Console.WriteLine("Email does not valid");
            }
        }
    }
}
