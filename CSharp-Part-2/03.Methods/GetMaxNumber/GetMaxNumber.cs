using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxNumber
{
    class GetMaxNumber
    {
        static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("First number = ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Second number = ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Third number = ");
            int thirdNum = int.Parse(Console.ReadLine());

            int maxNum = GetMax(GetMax(firstNum, secondNum), thirdNum);

            Console.WriteLine(maxNum);
        }
    }
}
