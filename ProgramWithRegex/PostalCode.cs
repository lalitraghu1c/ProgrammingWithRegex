using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class PostalCode
    {
        const string PIN_CODE_PATTERN1 = "^[0-9]{6}$";
        const string PIN_CODE_PATTERN2 = "^[0-9]{6}$";

        public void TestPinCode1(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN1))
                Console.WriteLine("Regex is matched");
            else
                Console.WriteLine("Regex doesnot match");
        }
        public void TestPinCode2(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN2))
                Console.WriteLine("Regex is matched");
            else
                Console.WriteLine("Regex doesnot match");
        }
    }
}
