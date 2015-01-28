using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        static void Main(string[] args)
        {
            int a = 245;
            int b = a % 10;
            int c = a % 100;
            string dsad = "dwqdsada";
            Console.WriteLine(UppercaseFirst(dsad));


        }
    }
}
