using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Sum_integers
{
    class SumIntegers
    {

        static int SumOfIntegers(string stringOfNumbers)
        {
            int sum = 0;
            string[] numbers = stringOfNumbers.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            Console.WriteLine(SumOfIntegers(numbers));
        }
    }
}