using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present).
class SumInArray
{
    static void Main()
    {
        int sum = 7;
        int[] array = new int[7] { 4, 3, 1, 2, 3, 1, 7 };
        int currentSum = 0;
        int start = 0;
        int final = 0;
        while (true)
        {
            currentSum += array[final];
            if (currentSum > sum)
            {
                start++;
                final = start;
                currentSum = 0;
            }
            if (currentSum < sum)
            {
                final++;
                if (currentSum == 0)
                {
                    final = start;
                }
            }
            if (currentSum == sum)
            {
                for (int i = start; i <= final; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
                start++;
                final = start;
                currentSum = 0;
                Console.WriteLine();
            }
            if (final == array.Length - 1)
            {
                start++;
                final = start;
                currentSum = 0;
            }
            if (start == array.Length - 1)
            {
                if (array[start] == sum)
                {
                    Console.WriteLine(array[start]);
                }
                break;
            }
            if (final == array.Length)
            {
                break;
            }
        }
    }
}