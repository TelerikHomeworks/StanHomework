using System;

class SelectionSort
{
    static void Main()
    {
        int[] array = new int[10] { 51, 23, 299, 100, 50, 25, 24, 69, 69, -40 };

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    int x = array[i];
                    array[i] = array[j];
                    array[j] = x;
                }
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.WriteLine(array[i]);
            }
            Console.Write(array[i] + ", ");
        }
    }
}