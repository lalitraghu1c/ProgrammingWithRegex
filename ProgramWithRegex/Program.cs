using RegexDemo;
using System;
using System.Runtime;

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
                Console.WriteLine("1. Check Pattern to validate Postal Code\n2. Restrict Postal Code at beggining\n3. Restrict Postal Code at ending\n4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                PostalCode code = new PostalCode();
                switch (option)
                {
                    case 1:
                        code.TestPinCode1("400088");
                        break;
                    case 2:
                        code.TestPinCode2("A400088");
                        break;
                    case 3:
                        code.TestPinCode3("40008A");
                        break;
                    case 4:
                        code.TestPinCode4("400 088");
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