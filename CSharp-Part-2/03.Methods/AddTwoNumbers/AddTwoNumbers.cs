using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class AddTwoNumbers
    {
        static string Reverse(char[] number)
        {
            if (number[0] == '-')
            {
                number[0] = ' ';
            }
            Array.Reverse(number);
            string result = String.Join("", number);
            return result;
        }

        static string AddTwoNums(byte[] firstArr, byte[] secondArr)
        {
            string result = "";
            int length = 0;
            int length2 = 0;
            bool firstIsBigger = true;
            if (firstArr.Length > secondArr.Length)
            {
                length = firstArr.Length;
                length2 = secondArr.Length;
                firstIsBigger = true;
            }
            else
            {
                length = secondArr.Length;
                length2 = firstArr.Length;
                firstIsBigger = false;
            }
            for (int i = 0; i < length; i++)
            {
                if (i < length2)
                {
                    if (firstArr[i] + secondArr[i] < 10)
                    {
                        result += firstArr[i] + secondArr[i];
                    }
                    else
                    {

                        if (i + 1 < length)
                        {
                            result += firstArr[i] + secondArr[i] - 10;
                            firstArr[i + 1]++;
                        }
                        else
                        {
                            result += firstArr[i] + secondArr[i];
                        }
                    }
                }
                else
                {
                    if (firstIsBigger == true)
                    {
                        result += firstArr[i];
                    }
                    else
                    {
                        result += secondArr[i];
                    }
                }
            }
            char[] res = result.ToCharArray();
            return Reverse(res);

        }

        static void Main(string[] args)
        {
            byte[] firstArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5, 2, 1, 5, 6, 7, 8, 9, 9, 6, 5, 4, 3, 2, 1, 3, 4,
                                5, 6, 7, 8, 9, 6, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5, 2, 1, 5, 6, 7, 8,
                                9, 9, 6, 5, 4, 3, 2, 1, 3, 4, 5, 6, 7, 8, 9, 6, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6,
                                7, 8, 5, 2, 1, 5, 6, 7, 8, 9, 9, 6, 5, 4, 3, 2, 1, 3, 4, 5, 6, 7, 8, 9, 6, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6,
                                7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5, 2, 1, 5, 6, 7, 8, 9, 9, 6, 5, 4, 5, 6, 7, 4, 3, 2, 3, 4, 4, 1, 2,
                                3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5, 2, 1, 5, 6, 7, 8, 9, 9, 6, 5, 4, 3, 2, 1, 3, 4, 5, 6,
                                7, 8, 9, 6, 4, 5, 6, 7, 8, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5, 2, 1, 5, 6, 7, 8, 9, 9,
                                6, 5, 4, 3, 2, 1, 3, 4, 5, 6, 7, 8};

            byte[] secondArr = { 5, 4, 3, 2, 9, 3, 4, 5, 6, 7, 1, 3, 4, 5, 6, 7, 8, 9, 3, 2, 1, 4, 5, 6, 7, 8, 9, 6, 5, 4, 3, 3, 5, 6, 7, 8,
                                 9, 9, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5, 2, 1, 5, 6, 7, 8, 9, 9, 6, 5, 4, 3, 2, 1, 3,
                                 4, 5, 6, 7, 8, 9, 6, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5, 2, 1, 5, 6,
                                 7, 8, 9, 9, 6, 5, 4, 5, 6, 7, 4, 3, 2, 3, 4, 4, 1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 3, 5, 6, 5, 3, 6, 7, 8, 5,
                                 2, 1, 5, 6, 7, 8, 9, 9, 6, 5, 4, 3, 2, 1, 3, 4, 5, 6 };

            Console.WriteLine(AddTwoNums(firstArr, secondArr));


        }
    }
}
