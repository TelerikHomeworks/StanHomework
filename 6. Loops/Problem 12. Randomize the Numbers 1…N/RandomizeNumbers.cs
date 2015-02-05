using System;
/*Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/
class RandomizeNumbers
{
    public static void Shuffle(int[] array)
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            int idx = random.Next(i, array.Length);

            //swap elements
            int tmp = array[i];
            array[i] = array[idx];
            array[idx] = tmp;
        }
    }
    static void Main()
    {
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }
        Shuffle(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}