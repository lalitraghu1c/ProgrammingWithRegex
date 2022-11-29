using RegexDemo;
using System;
namespace ProgrammingWithRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Programming With Regex Problem Statements");
            Console.WriteLine("Select Below Mention Options");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine("1. Check Pattern to validate Postal Code\n2. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PostalCode code = new PostalCode();
                        code.TestPinCode("400088");
                        break;
                    default:
                        choice = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}