using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumApear
{
    class CountNumApear
    {
        static int numberApear(double[] myArray, double num)
        {
            int counter = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i]==num)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            double[] someArray = { 0,1,2,3,3,2,4,4,2,4 };
            int number = 4;
            Console.WriteLine("Number {0} apear {1} times in the array!",number,numberApear(someArray,number));
        }
    }
}
