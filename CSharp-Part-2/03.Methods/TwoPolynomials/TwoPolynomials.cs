using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPolynomials
{
    class TwoPolynomials
    {
        static void PrintPolynom(decimal[] arr)
        {
            int length = arr.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    if (arr[i] != 0)
                    {
                        Console.Write("{0}x^{1} + ", arr[i], i);
                    }

                }
                else
                {
                    Console.Write("{0}", arr[i]);
                }
            }
            Console.WriteLine();

        }

        static decimal[] AddTwoPolynoms(decimal[] first, decimal[] second, bool subtract = false)
        {
            decimal[] result;
            if (first.Length>=second.Length)
            {
                result = new decimal[first.Length];
                Array.Copy(first, result, first.Length);
                for (int i = 0; i < second.Length; i++)
                {
                    if (subtract == false) result[i] += second[i];
                    else result[i] -= second[i];       
                }
            }
            else
            {
                result = new decimal[second.Length];
                Array.Copy(second, result, second.Length);
                for (int i = 0; i < first.Length; i++)
                {
                    if (subtract == false) result[i] += first[i];
                    else result[i] -= first[i];
                }
            }
            return result;
        }

        static decimal[] MultiplicateTwoPolynoms(decimal[] first, decimal[] second)
        {
            decimal[] result = new decimal[first.Length + second.Length];

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    int position = i + j;
                    result[position] += (first[i] * second[j]);
                }
            }
            return result;

        }

        static void Main(string[] args)
        {
            decimal[] firstPolynom = { 1, 3, 5, 0, 4 };
            Console.Write("X = ");
            PrintPolynom(firstPolynom);
            decimal[] secondPolynom = { 2, 3, 4 };
            Console.Write("Y = ");
            PrintPolynom(secondPolynom);
            Console.Write("X + Y = ");
            PrintPolynom(AddTwoPolynoms(firstPolynom, secondPolynom, false));
            Console.Write("X - Y = ");
            PrintPolynom(AddTwoPolynoms(firstPolynom, secondPolynom, true));
            Console.Write("X * Y = ");
            PrintPolynom(MultiplicateTwoPolynoms(firstPolynom, secondPolynom));

        }
    }
}
