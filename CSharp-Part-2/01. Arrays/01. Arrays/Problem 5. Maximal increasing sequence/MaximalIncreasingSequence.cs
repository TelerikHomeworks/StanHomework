using System;
//Problem 5. Maximal increasing sequence
class MaximalIncreasingSequence
{
    static void Main()
    {
        int count = 1;
        int maxSequence = 0;
        int firstElement = 0;
        Console.Write("Please enter elements in one line --> ");
        string[] tokens = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(tokens, s => int.Parse(s));
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int j = i + 1;
            while (numbers[i] + count == numbers[j])
            {
                j++;
                count++;
                if (j == numbers.Length)
                {
                    break;
                }
            }
            if (maxSequence < count)
            {
                firstElement = numbers[i];
                maxSequence = count;
            }
            count = 1;
        }
        for (int i = 0; i < maxSequence; i++)
        {
            if (i == maxSequence - 1)
            {
                Console.WriteLine("{0}", firstElement + i);
                break;
            }
            Console.Write("{0}, ", firstElement + i);
        }
    }
}