using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Reverse(char[] number)
        {
            if (number[0] == '-')
            {
                number[0] = ' ';
            }
            Array.Reverse(number);
            string result = String.Join("", number);
            decimal decimalResult = decimal.Parse(result);
            Console.WriteLine(decimalResult);
        }

        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            char[] digitsArr = number.ToCharArray();
            Reverse(digitsArr);
        }
    }
}
