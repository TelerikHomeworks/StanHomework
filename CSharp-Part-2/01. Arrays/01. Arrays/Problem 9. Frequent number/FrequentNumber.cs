using System;
//Write a program that finds the most frequent number in an array.
class FrequentNumber
{
    static void Main()
    {
        int[] array = new int[13] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int count = 1;
        int maxCount = 0;
        int maxNumber = 0;
        int i = 0;

        while (i < array.Length)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
                maxNumber = i;
            }
            i++;
            count = 1;
        }
        Console.WriteLine("{0}({1} times)", array[maxNumber], maxCount - 1);
    }
}