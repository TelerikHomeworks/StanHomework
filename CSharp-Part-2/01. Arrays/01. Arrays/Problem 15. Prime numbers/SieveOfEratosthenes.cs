using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            int n = 10000000;
            bool[] numbers = new bool[n];
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (numbers[i] == false)
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        numbers[j] = true;
                    }
                }

            }

            for (int i = 2; i < n; i++)
            {
                if (numbers[i] == false)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}