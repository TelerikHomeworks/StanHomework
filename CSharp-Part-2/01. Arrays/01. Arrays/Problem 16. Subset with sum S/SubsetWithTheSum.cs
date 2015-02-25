﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetWithTheSum
{
    static void Main()
    {
        int sumToFind = -1;
        int[] myArray = { 6, -6, 5, 8, 8, -9, 2 };
        int currentSum = 0;
        int startIndex = 0;
        int count = 0;
        bool hasBeenFound = false;
        bool sumToFindisZero = false;

        if (sumToFind == 0)
        {
            sumToFindisZero = true;
            currentSum = -1;
        }

        while (currentSum != sumToFind && startIndex != myArray.Length)
        {
            if (sumToFindisZero == true)
            {
                currentSum = 0;
                sumToFindisZero = false;
            }

            for (int i = startIndex; i < myArray.Length; i++)
            {
                currentSum += myArray[i];
                count++;
                if (currentSum == sumToFind)
                {
                    hasBeenFound = true;
                    break;
                }
            }

            if (currentSum != sumToFind)
            {
                startIndex++;
                count = 0;
                currentSum = 0;
            }
        }

        if (hasBeenFound == false)
        {
            Console.WriteLine("Sorry! Have not found anything!");
        }
        else
        {
            for (int i = startIndex; i < startIndex + count; i++)
            {
                Console.Write("{0} ", myArray[i]);
            }
            Console.WriteLine();
        }

    }
}