﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that sorts an array of strings using the Quick sort algorithm.

namespace QuickSort
{
    class QuickSort
    {
        static List<int> MakeQuickSort(List<int> unsortedList)
        {
            if (unsortedList.Count <= 1)
            {
                return unsortedList;
            }
            int pivot = unsortedList.Count / 2;
            int pivotValue = unsortedList[pivot];
            unsortedList.RemoveAt(pivot);
            List<int> lesser = new List<int>();
            List<int> greater = new List<int>();
            foreach (int element in unsortedList)
            {
                if (element <= pivotValue)
                {
                    lesser.Add(element);
                }
                else
                {
                    greater.Add(element);
                }
            }
            List<int> result = new List<int>();
            result.AddRange(MakeQuickSort(lesser));
            result.Add(pivotValue);
            result.AddRange(MakeQuickSort(greater));
            return result;

        }
        static void Main()
        {
            List<int> array = new List<int> { 2, 3, 5, 0, 123, 3, 23, 1234, 87 };
            List<int> sortedArray = MakeQuickSort(array);
            foreach (var item in sortedArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}