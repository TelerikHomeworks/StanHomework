using System;
using System.Text;

class MinMaxAvrgProduct
{
    static int FindMax(params int[] arr)
    {
        int biggestNum = arr[0];
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if (length > 0)
            {
                if (arr[i] > biggestNum)
                {
                    biggestNum = arr[i];
                }
            }
            else
            {
                return 0;
            }
        }
        return biggestNum;
    }

    static int FindMin(params int[] arr)
    {
        int smallest = arr[0];
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if (length > 0)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            else
            {
                return 0;
            }
        }
        return smallest;
    }

    static decimal FindAvrg(params int[] arr)
    {
        decimal counter = 0;
        decimal sum = 0;
        decimal sumAvg = 0;
        foreach (var number in arr)
        {
            sum = sum + number;
            counter++;
        }
        sumAvg = sum / counter;
        return sumAvg;
    }

    static int FindSum(params int[] arr)
    {
        int sum = 0;
        foreach (var number in arr)
        {
            sum += number;
        }
        return sum;
    }
    static int FindProduct(params int[] arr)
    {
        int product = 1;
        foreach (var number in arr)
        {
            product *= number;
        }
        return product;
    }
    static void Main()
    {
        int[] elements = { 5, 10, 11, 15, 3, 4, 8, 2 };
        Console.WriteLine("Minimal element = {0}", FindMin(elements));
        Console.WriteLine("Maximal element = {0}", FindMax(elements));
        Console.WriteLine("Average element = {0}", FindAvrg(elements));
        Console.WriteLine("The sum of the elements = {0}", FindSum(elements));
        Console.WriteLine("The product of the elements = {0}", FindProduct(elements));
        Console.WriteLine();
    }
}