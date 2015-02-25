using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBiggerThanNeighbours
{
    class FirstBiggerThanNeighbours
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

            if (position > 0 && position <= myArray.Length - 1 && flag==true)
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
        static int getIndexOfFirst(double[] myArray)
        {
            int i;
            bool flag = false;
            for (i = 0; i < myArray.Length; i++)
            {
                if (IsItBigger(myArray,i)==true)
                {
                    flag = true;
                    break;
                }
            }
            if (flag==true)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            double[] someArray = { 0, 1, 2, 3, 3, 6, 4, 4, 2, 4 };
            Console.WriteLine("The index of the first element bigger than its neighbours is {0}",getIndexOfFirst(someArray));
        }
    }
}
