using System;
/*We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem.*/
//1 2 -1 5 6
class ZeroSubset
{
    static void Main()
    {
        bool zeroSubset = false;
        string buffer = " ";
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number {0} --->> ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        //first check for each 2 numbers
        for (int i = 0; i < 4; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    if (buffer != string.Format("{0} + {1} = 0", numbers[i], numbers[j]))
                    {
                        buffer = string.Format("{0} + {1} = 0", numbers[i], numbers[j]);
                        Console.WriteLine(buffer);
                    }
                    zeroSubset = true;
                }
            }
        }
        //check for each 3 numbers
        for (int i = 0; i < 3; i++)
        {
            for (int j = i + 1; j < 4; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    if (numbers[i] + numbers[j] + numbers[k] == 0)
                    {
                        if (buffer != string.Format("{0} + {1} + {2} = 0", numbers[i], numbers[j], numbers[k]))
                        {
                            buffer = string.Format("{0} + {1} + {2} = 0", numbers[i], numbers[j], numbers[k]);
                            Console.WriteLine(buffer);
                        }
                        zeroSubset = true;
                    }
                }
            }
        }
        //check for sum of 4 numbers
        for (int i = 0; i < 2; i++)
        {
            for (int j = i + 1; j < 3; j++)
            {
                for (int k = j + 1; k < 4; k++)
                {
                    for (int m = k + 1; m < 5; m++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] + numbers[m] == 0)
                        {
                            if (buffer != string.Format("{0} + {1} + {2} + {3} = 0", numbers[i], numbers[j], numbers[k], numbers[m]))
                            {
                                buffer = string.Format("{0} + {1} + {2} + {3} = 0", numbers[i], numbers[j], numbers[k], numbers[m]);
                                Console.WriteLine(buffer);
                            }
                            zeroSubset = true;
                        }
                    }
                }
            }
        }
        //check for sum of 5
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += numbers[i];
        }
        if (sum == 0)
        {
            zeroSubset = true;
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
        }
        if (!zeroSubset)
        {
            Console.WriteLine("no zero subset");
        }
    }
}