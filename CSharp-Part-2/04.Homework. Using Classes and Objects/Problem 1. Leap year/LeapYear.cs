using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year)? "{0} is leap" : "{0} isn't leap", year);
        }
    }
}
