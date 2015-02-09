﻿using System;
//Write a program that finds the sequence of maximal sum in given array.
class MaxSumSequence
{
    static void Main(string[] args)
    {
        int[] myArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int currentSum = myArray[0];
        int maxSum = myArray[0];
        int tempStart = 0;
        int bestStart = 0;
        int bestFinal = 0;

        for (int i = 1; i < myArray.Length; i++)
        {
            currentSum += myArray[i];
            if (myArray[i] > currentSum)
            {
                currentSum = myArray[i];
                tempStart = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                bestStart = tempStart;
                bestFinal = i;
            }
        }

        for (int i = bestStart; i <= bestFinal; i++)
        {
            Console.Write("{0} ", myArray[i]);
        }
        Console.WriteLine();
    
    }
}