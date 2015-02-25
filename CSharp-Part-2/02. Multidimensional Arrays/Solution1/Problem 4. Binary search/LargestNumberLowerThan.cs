using System;

class LargestNumberLowerThan
{
    static void Main()
    {
        int[] array = { 9, 0, 3, 1, 3, 6, 7, 7 };
        int K = 5;

        Array.Sort(array);
        //Array.Sort(array, (x, y) => (x).CompareTo(y));

        int searchedNumber = Array.BinarySearch(array, K);
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        if (searchedNumber < -1)
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[~searchedNumber - 1]);
        }
        else if (~searchedNumber == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("Largest number lower than or equal to {0} is {1}", K, array[searchedNumber]);
        }
    }
}