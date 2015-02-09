using System;
/*Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/

class MaxSumOfKElements
{
    //Метод който изтрива най-големия елемент от масива
    public static int[] removeMaxElement(int[] arr)
    {
        int[] newArray = new int[arr.Length - 1];
        int max = arr[0];
        int maxElementIndex = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                maxElementIndex = i;
            }
        }
        for (int i = 0; i < maxElementIndex; i++)
        {
            newArray[i] = arr[i];
        }
        for (int i = maxElementIndex; i < newArray.Length; i++)
        {
            newArray[i] = arr[i + 1];
        }
        return newArray;
    }
    //end 
    //Return biggest number in array
    public static int maxElementOfArray(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }
    //Find max sum of K numbers in array
    public static int SumOfElements(int[] arr, int K)
    {
        int sum = 0;
        while (0 < K)
        {
            sum += maxElementOfArray(arr);
            arr = removeMaxElement(arr);
            K--;
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[N];
        Console.Write("Enter K: ");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements in array each on a single line. ");
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Max sum of {0} elements --->->>->>> {1}", K, SumOfElements(arr, K));
    }
}