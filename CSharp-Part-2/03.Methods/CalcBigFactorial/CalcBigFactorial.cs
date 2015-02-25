using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalcBigFactorial
{
    class CalcBigFactorial
    {
        static BigInteger CalcFactorial(int n)
        {
            BigInteger factorial = n;
            while (n > 0)
            {
                factorial *= n;
                n--;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[100];

            for (int i = 0; i < 100; i++)
            {
                myArray[i] = i + 1;
                Console.WriteLine("{0}! = {1}",myArray[i],CalcFactorial(myArray[i]));
            }
        }
    }
}
