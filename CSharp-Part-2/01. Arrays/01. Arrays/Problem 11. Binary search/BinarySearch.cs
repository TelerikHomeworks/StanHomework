using System;
//Write a program that finds the index of given element in a sorted array of integers by using
//the Binary search algorithm.
class BinarySearch
{
    static void Main()
    {
        int[] array = new int[10] { 4, 14, 16, 25, 29, 66, 69, 77, 81, 100 };

        int key = 69;
        int start = 0;
        int end = array.Length - 1;
        int mid = (start + end) / 2;

        while (start <= end)
        {
            mid = (start + end) / 2;
            if (key == array[mid])
            {
                Console.WriteLine("Found! Index is {0}", mid);
                return;
            }
            else if (key < array[mid])
            {
                end = mid - 1;
            }
            else if (key > array[mid])
            {
                start = mid + 1;
            }
        }
        Console.WriteLine("Not Found");
    }
}