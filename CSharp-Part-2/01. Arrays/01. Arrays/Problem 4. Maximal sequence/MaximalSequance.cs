using System;
//Write a program that finds the maximal sequence of equal elements in an array.
class MaximalSequance
{
    static void Main()
    {
        int count = 0;
        int maxSequence = 0;
        string longestElement="";
        Console.Write("Please enter elements in one line --> ");
        string[] tokens = Console.ReadLine().Split();
        for (int i = 0; i < tokens.Length - 1; i++)
        {
            int j = i + 1;
            while (tokens[i] == tokens[j])
            {
                count++;
                j++;
                if (j == tokens.Length)
                {
                    break;
                }
            }
            if (maxSequence < count)
            {
                maxSequence = count;
                longestElement = tokens[i];
            }
            count = 0;
        }
        for (int i = 0; i < maxSequence + 1; i++)
        {
            if (i == maxSequence)
            {
                Console.WriteLine("{0}", longestElement);
                break;
            }
            Console.Write("{0}, ", longestElement);
        }
    }
}