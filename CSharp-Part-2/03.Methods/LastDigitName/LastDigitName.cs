using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitName
{
    class LastDigitName
    {
        static string GetLastDigit(int num)
        {
            int lastDigit = num % 10;
            string lastDigitName = "";
            switch (lastDigit)
            {
                case 0: lastDigitName = "zero"; break;
                case 1: lastDigitName = "one"; break;
                case 2: lastDigitName = "two"; break;
                case 3: lastDigitName = "three"; break;
                case 4: lastDigitName = "four"; break;
                case 5: lastDigitName = "five"; break;
                case 6: lastDigitName = "six"; break;
                case 7: lastDigitName = "seven"; break;
                case 8: lastDigitName = "eight"; break;
                case 9: lastDigitName = "nine"; break;
                default: lastDigitName = "Invalid Number!"; break;
            }

            return lastDigitName;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigit(number));
        }
    }
}
