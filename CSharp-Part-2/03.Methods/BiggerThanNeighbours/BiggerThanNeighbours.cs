using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerThanNeighbours
{
    class BiggerThanNeighbours
    {
        static bool IsItBigger(double[] myArray, int position)
        {
            bool flag = true;
            if (position >= 0 && position < myArray.Length - 1)
            {
                if (myArray[position] > myArray[position + 1])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            if (position > 0 && position <= myArray.Length - 1 && flag == true)
            {
                if (myArray[position] > myArray[position - 1])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }

            return flag;
        }

        static void Main(string[] args)
        {
            double[] someArray = { 0, 1, 2, 3, 3, 6, 4, 4, 2, 4 };
            int position = 1;

            Console.WriteLine(IsItBigger(someArray, position));
        }
    }
}
